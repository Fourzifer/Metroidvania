using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoor : MonoBehaviour
{

    public int switches;
    public GameObject puzzleDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorSwitch.switchActive == true)
        {
            Destroy(gameObject);
        }
    }
}
