using UnityEngine;
using UnityEngine.SceneManagement;

using System. Collections;
using System. Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;
    void FixedUpdate()
    {
        if (Input.GetKey(keyRestart)){
        // Resume the scene
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
        }
    }
}