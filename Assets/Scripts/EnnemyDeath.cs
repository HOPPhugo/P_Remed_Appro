using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int scoreValue = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Joueur")
        {
            ScoreManager.instance.AddScore(scoreValue);
        }
    }
}