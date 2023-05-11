using UnityEngine;
using TMPro;

public class P2Score : MonoBehaviour
{
    public int player2Score = 0;
    public TextMeshProUGUI scoreText;

    private bool hasCollided = false;

    void Start()
    {
        scoreText = GameObject.Find("Player2Score").GetComponent<TextMeshProUGUI>();
        player2Score = PlayerPrefs.GetInt("Player2Score", 0); // Load the saved score
        scoreText.text = "Player 2 Score: " + player2Score;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") && !hasCollided)
        {
            player2Score++;
            scoreText.text = "Player 2 Score: " + player2Score;
            PlayerPrefs.SetInt("Player2Score", player2Score); // Save the new score
            hasCollided = true;
            // add code to show a message or play a sound effect
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            hasCollided = false;
        }
    }
}
