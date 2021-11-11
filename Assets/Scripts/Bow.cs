using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public GameObject fireArrow;
    public GameObject iceArrow;
    private GameObject element;

    public bool hasFire;

    public float launchForce;
    public Transform shotPoint;
    Vector2 direction;

    private int forceAcceleration = 15;
    private int maxForce = 15;
    public static bool pullingString = false;

    private int arrowType;

    [SerializeField] private Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        hasFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePosition - bowPosition;
        transform.right = direction;

        void Shoot()
        {
            GameObject newArrow = Instantiate(element, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        }

        if (Input.GetMouseButton(0))
        {
            pullingString = true;
            anim.SetBool("isDrawing", true);

            if (launchForce < maxForce)
            {
                launchForce += forceAcceleration * Time.deltaTime;
            }
            else
            {
                launchForce = maxForce;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
            launchForce = 5;
            pullingString = false;
            anim.SetBool("isDrawing", false);
        }

        switch (arrowType)
        {
            case 1:
                element = arrow;
                break;
            case 2:
                element = fireArrow;
                break;
            case 3:
                element = iceArrow;
                break;
            default:
                element = arrow;
                break;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            arrowType = 1;
            print("Standard");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2) && (hasFire == true))
        {
            arrowType = 2;
            print("Fire");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            arrowType = 3;
            print("Ice");
        }
    }
}
