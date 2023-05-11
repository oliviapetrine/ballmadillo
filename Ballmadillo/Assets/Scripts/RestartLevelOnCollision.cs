using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField] GameObject uiCanvas;
    public TMP_Text winningPlayerText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1")){
            winningPlayerText.text = "Player 2 won!";
            uiCanvas.SetActive(true);
        // Pause the scene
        Time.timeScale = 0f;
        }
        else if(collision.gameObject.CompareTag("Player2")){
            winningPlayerText.text = "Player 1 won!";
            uiCanvas.SetActive(true);
        // Pause the scene
        Time.timeScale = 0f;
        }
        

    }
}