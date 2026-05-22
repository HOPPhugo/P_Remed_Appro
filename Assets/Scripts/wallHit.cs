using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class wallHit : MonoBehaviour
{
    public AudioSource scream;
    public AudioSource metal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            metal.Play();
        }
        else if (collision.gameObject.tag == "Joueur")
        {
            scream.Play();
        }
    }
}
