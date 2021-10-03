using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{

    public static bool isSwitchActive;

    // Start is called before the first frame update
    void Start()
    {
        isSwitchActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            isSwitchActive = true;
            Debug.Log("Hit");
        }
    }
}
