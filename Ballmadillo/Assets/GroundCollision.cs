using UnityEngine;
using TMPro;

public class GroundColli : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int player1Score = 0;
    private int player2Score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            player2Score++;
            UpdateScoreText();
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            player1Score++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Player 1: " + player1Score + "\nPlayer 2: " + player2Score;
    }
}
