using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public GameObject fireArrow;

    public float launchForce;
    public Transform shotPoint;
    Vector2 direction;

    private int forceAcceleration = 10;
    private int maxForce = 15;
    public static bool pullingString = false;

    //public GameObject point;
    //GameObject[] points;
    //public int numberOfPoints;
    //public float spaceBetweenPoints;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    points = new GameObject[numberOfPoints];
    //    for(int i = 0; i < numberOfPoints; i++)
    //    {
    //        points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePosition - bowPosition;
        transform.right = direction;

        //for (int i = 0; i < numberOfPoints; i++)
        //{
        //    points[i].transform.position = PointPosition(i * spaceBetweenPoints);
        //}

        void Shoot()
        {
            GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        }

        void ShootFire()
        {
            GameObject newArrow = Instantiate(fireArrow, shotPoint.position, shotPoint.rotation);
            newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        }

        if (Input.GetMouseButton(0))
        {
            pullingString = true;
            if (launchForce < maxForce)
            {
                launchForce += forceAcceleration * Time.deltaTime;
            }
            else
            {
                launchForce = maxForce;
            }
        }

        if (Input.GetMouseButton(1))
        {
            pullingString = true;
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
        }

        if (Input.GetMouseButtonUp(1))
        {
            ShootFire();
            launchForce = 5;
            pullingString = false;
        }
    }

    //Vector2 PointPosition(float t)
    //{
    //    Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity;
    //    return position;
    //}
}
