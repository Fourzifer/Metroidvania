using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{

    public static bool switchActive;

    // Start is called before the first frame update
    void Start()
    {
        switchActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            switchActive = true;
            Debug.Log("Hit");
        }
    }
}
