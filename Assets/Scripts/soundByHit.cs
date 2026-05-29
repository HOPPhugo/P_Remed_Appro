using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class soundByGit : MonoBehaviour
{
    public AudioSource ZaHando;
    public AudioSource bombe;
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
            bombe.Play();
        }
        else if (collision.gameObject.tag == "Joueur")
        {
            ZaHando.Play();
        }
    }
    private void ScoreManager()
    {

    }
}
