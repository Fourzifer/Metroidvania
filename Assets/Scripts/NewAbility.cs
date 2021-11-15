using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAbility : MonoBehaviour
{
    public GameObject abilityImage;
    public string abilityType;
    public static bool hasFire;
    public static bool hasIce;
    public static bool hasIron;
    public static bool hasBoots;

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

        if (other.gameObject.tag == "Player")
        {
            if (abilityType == "Fire")
            {
                Debug.Log("Unlocked Fire");
                hasFire = true;
                abilityImage.SetActive(true);
            }

            if (abilityType == "Ice")
            {
                Debug.Log("Ice");
                hasIce = true;
                abilityImage.SetActive(true);
            }

            if (abilityType == "Iron")
            {
                Debug.Log("Iron");
                hasIron = true;
            }

            if (abilityType == "Boots")
            {
                Debug.Log("Boots");
                hasBoots = true;
            }

            Destroy(gameObject);
        }
    }
}
