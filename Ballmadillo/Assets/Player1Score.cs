using UnityEngine;
using TMPro;

public class Player1Score : MonoBehaviour
{
    public int player1Score = 0;
    public TextMeshProUGUI scoreText;

    private bool hasCollided = false;

    void Start()
    {
        scoreText = GameObject.Find("Player1Score").GetComponent<TextMeshProUGUI>();
        player1Score = PlayerPrefs.GetInt("Player1Score", 0); // Load the saved score
        scoreText.text = "Player 1 Score: " + player1Score;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2") && !hasCollided)
        {
            player1Score++;
            scoreText.text = "Player 1 Score: " + player1Score;
            PlayerPrefs.SetInt("Player1Score", player1Score); // Save the new score
            hasCollided = true;
            // add code to show a message or play a sound effect
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            hasCollided = false;
        }
    }
}