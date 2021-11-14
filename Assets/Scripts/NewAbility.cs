using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAbility : MonoBehaviour
{
    public string abilityType;
    public static bool hasFire;
    public static bool hasIce;
    public static bool hasIron;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //switch (abilityType)
        //{
        //    case 1:
        //        print("Unlocked Fire Arrows");
        //        return;
        //    default:
        //        print("No type");
        //        return;
        //}
        //Destroy(gameObject);
        if (abilityType == "Fire")
        {
            Debug.Log("Unlocked Fire");
            hasFire = true;
        }

        if (abilityType == "Ice")
        {
            Debug.Log("Ice");
            hasIce = true;
        }

        if (abilityType == "Iron")
        {
            Debug.Log("Iron");
            hasIron = true;
        }

        Destroy(gameObject);
    }
}
