using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextEnd;

    private void Awake()
    {
        instance = this;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score : " + score;
        scoreTextEnd.text = "Score : " + score;
    }
}