using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public static bool switchIsActive;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Box")
        {
            switchIsActive = true;
            Debug.Log("Opened");
            //Destroy(door);
            door.SetActive(false);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Box")
        {
            switchIsActive = false;
            Debug.Log("Closed");
            door.SetActive(true);
        }
    }
}