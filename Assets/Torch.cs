using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject flame;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FireArrow" || other.gameObject.tag == "Fire")
        {
            sr = GetComponent<SpriteRenderer>();
            sr.color = Color.red;
            flame.SetActive(true);

            gameObject.tag = "Fire";
        }
    }
}
