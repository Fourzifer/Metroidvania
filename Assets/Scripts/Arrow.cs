using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Vector3 lastPosition;
    public GameObject icePlatform;

    Rigidbody2D rb;
    bool hasHit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hasHit = true;
        rb.velocity = Vector2.zero;
        //remember that they are kinematic and can't collide
        rb.isKinematic = true;

        if (other.gameObject.tag == "Chain")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (gameObject.tag == "FireArrow" && other.gameObject.tag == "Wood")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Debug.Log("Fire");
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Water" && gameObject.tag == "IceArrow")
        {
            print("Water");
            lastPosition = transform.position;
            Instantiate(icePlatform, lastPosition, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
