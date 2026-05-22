using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bullet : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 40;
    //public LineRenderer lineRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shoot());
        }
    }
    IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {/*
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }*/


            /*lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);*/
        }
        else
        {
           /* lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);*/
        }

        //lineRenderer.enabled = true;

        yield return 0;

        //lineRenderer.enabled = false;
    }
}

