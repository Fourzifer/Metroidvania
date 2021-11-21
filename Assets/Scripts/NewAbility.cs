using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAbility : MonoBehaviour
{
    public GameObject abilityImage;
    public GameObject bow;
    public string abilityType;
    public static bool hasFire;
    public static bool hasIce;
    public static bool hasIron;
    public static bool hasBoots;
    public static bool hasArrows;

    private void OnCollisionEnter2D(Collision2D other)
    {
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

            if (abilityType == "Arrows")
            {
                Debug.Log("Arrows");
                hasArrows = true;
                bow.SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}