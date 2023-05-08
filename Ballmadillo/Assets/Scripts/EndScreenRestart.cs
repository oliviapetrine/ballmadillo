using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenRestart : MonoBehaviour
{
    public void OnButtonPress(){
        // Resume the scene
        Time.timeScale = 1f;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Time.timeScale = 1f;
   }
}
