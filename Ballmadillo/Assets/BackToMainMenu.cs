using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public void OnClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        

        SceneManager.LoadScene("Menu");
        RestartLevelOnCollision levelRestart = FindObjectOfType<RestartLevelOnCollision>();
        if (levelRestart != null) {
            levelRestart.ResetScores();
        }
    }
}
