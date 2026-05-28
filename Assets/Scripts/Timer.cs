using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

        }
        else
        {
            timeRemaining = 0;
                // Game Over logic here
                Debug.Log("Game Over!");
        }
    }
}
