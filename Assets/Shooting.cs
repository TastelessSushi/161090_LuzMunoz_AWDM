using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject projectileDone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Shooting logic
        Instantiate(projectileDone, shootingPoint.position, shootingPoint.rotation);
    }
}
