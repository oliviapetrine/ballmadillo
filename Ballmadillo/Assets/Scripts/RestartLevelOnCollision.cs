using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public static class ScoreManager
{
    public static int player1Score = 0;
    public static int player2Score = 0;
}

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField] GameObject uiCanvas;
    public TMP_Text winningPlayerText;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    private bool player1Scored = false;
    private bool player2Scored = false;

    private void Start()
    {
        player1ScoreText.text = "Player 1 Score: " + ScoreManager.player1Score;
        player2ScoreText.text = "Player 2 Score: " + ScoreManager.player2Score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1") && !player1Scored){
            ScoreManager.player2Score++;
            player2ScoreText.text = "Player 2 Score: " + ScoreManager.player2Score;

            winningPlayerText.text = "Player 2 won!";
            uiCanvas.SetActive(true);
            // Pause the scene
            Time.timeScale = 0f;

            player1Scored = true;
        }
        else if(collision.gameObject.CompareTag("Player2") && !player2Scored){
            ScoreManager.player1Score++;
            player1ScoreText.text = "Player 1 Score: " + ScoreManager.player1Score;

            winningPlayerText.text = "Player 1 won!";
            uiCanvas.SetActive(true);
            // Pause the scene
            Time.timeScale = 0f;

            player2Scored = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            player1Scored = false;
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            player2Scored = false;
        }
    }

    public void ResetScores()
    {
        ScoreManager.player1Score = 0;
        ScoreManager.player2Score = 0;
        player1ScoreText.text = "Player 1 Score: " + ScoreManager.player1Score;
        player2ScoreText.text = "Player 2 Score: " + ScoreManager.player2Score;

        player1Scored = false;
        player2Scored = false;
    }
}
