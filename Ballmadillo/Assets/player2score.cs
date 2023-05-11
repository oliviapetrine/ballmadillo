using UnityEngine;
using TMPro;

public class player2Score: MonoBehaviour
{
    public int Player2Score = 0;
    public TextMeshProUGUI scoreText;
    private bool isColliding = false;

    void Start()
    {
        scoreText = GameObject.Find("Player2Score").GetComponent<TextMeshProUGUI>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") && !isColliding)
        {
            Player2Score++;
            scoreText.text = "Player 2 Score: " + Player2Score;
            // add code to show a message or play a sound effect
            isColliding = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            isColliding = false;
        }
    }
}
