using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Arrow"))
    //    {
    //        enemyHealth--;
    //        Debug.Log("Health down");
    //    }
    //}
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            enemyHealth--;
        }
    }
}