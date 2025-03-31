using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce;
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //if left mouse button has been clicked
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation); // spawn bullet prefab with refernce to the bullet spawn transform

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce); //get refernece to the rigidbosy component and add force forwards multiplied by public float bulletForce

            Destroy(bullet, 3f); //destroy bullet after 3 seconds
        }
    }
}
