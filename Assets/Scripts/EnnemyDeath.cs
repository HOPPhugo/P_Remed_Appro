using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 40;
    public int scoreValue = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ScoreManager.instance.AddScore(scoreValue);

        Destroy(gameObject);
    }
}