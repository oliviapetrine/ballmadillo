using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMap : MonoBehaviour
{
    public AudioSource music;

    public void Map1(){
        music.Stop(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Map2(){
        music.Stop(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
