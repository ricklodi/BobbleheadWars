using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform launchPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void fireBullet()
    {
        // Create a new bullet object from the Prefab by Cloning the bulletPrefab
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;    //as means casting
        //Placing the bullet at the launcher position
        bullet.transform.position = launchPosition.position;
        //Giving the bullet an initial velocity to take off with
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!IsInvoking("fireBullet"))
            {
                InvokeRepeating("fireBullet", 0f, 0.1f);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("fireBullet");
        }
    }
}
