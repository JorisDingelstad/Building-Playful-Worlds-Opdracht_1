using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bulletRedPrefab;
    public GameObject bulletBluePrefab;
    public GameObject bulletYellowPrefab;
    public int bulletSpeed = 500;
    public static bool allowFireRed = false;
    public static bool allowFireBlue = false;
    public static bool allowFireYellow = false;

    
    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (allowFireRed == true)
            {


                GameObject newBullet = (GameObject)Instantiate(bulletRedPrefab, this.transform.position, this.transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
            }

            if (allowFireBlue == true)
            {


                GameObject newBullet = (GameObject)Instantiate(bulletBluePrefab, this.transform.position, this.transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
            }

            if (allowFireYellow == true)
            {


                GameObject newBullet = (GameObject)Instantiate(bulletYellowPrefab, this.transform.position, this.transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
            }
        }


	}
}
