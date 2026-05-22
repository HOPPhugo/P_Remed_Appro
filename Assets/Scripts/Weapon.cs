using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    bool shootAllow = true;
    public AudioSource pop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shootAllow == true)
            {
                Shoot();
            }
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        pop.Play();
        shootAllow = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        shootAllow = true;
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "Bullet")
        {
            Destroy(bulletPrefab);
            //Do something, like reduce player's health
        }else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(bulletPrefab);
        }
    }
}