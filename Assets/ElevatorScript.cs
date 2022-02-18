using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    [SerializeField] private MovingObject movingObject;

    // Start is called before the first frame update
    void Start()
    {
        //movingObject.enabled = true;
        movingObject = GetComponent<MovingObject>();
        movingObject.enabled = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            movingObject.enabled = true;
        }
    }
}
