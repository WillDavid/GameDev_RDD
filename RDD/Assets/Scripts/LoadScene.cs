using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadScene(string nomeCena){
        SceneManager.LoadScene(nomeCena);
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
