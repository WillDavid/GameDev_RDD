using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int movimentosRestantes = 10;
    public Text movimentoRestantesText;
    public static GameController instance;
    // Start is called before the first frame update
   
    public AudioSource backgroundSong;
    public GameObject panelPause;
    private GameObject cameraPosicao;
    


   
    void Start()
    {
       instance = this;
       movimentoRestantesText.text = movimentosRestantes.ToString();
       cameraPosicao = GameObject.Find("Camera Configurada");
       

      
    
    }


    
   


    public void TimeGame(){
       

        if(movimentosRestantes >= 0){
            movimentosRestantes = movimentosRestantes - 1;
            Debug.Log(movimentosRestantes);
            if(movimentosRestantes == -1){
                movimentosRestantes = 0;
        }
        }

        movimentoRestantesText.text = movimentosRestantes.ToString();
        
    }

    public void loadScene(string nomeCena){
        SceneManager.LoadScene(nomeCena);
        Time.timeScale = 1;
    }

    public void PainelPauseTrue(){
      
            //panelPause.transform.position = Vector2.MoveTowards(panelPause.transform.position, cameraPosicao.transform.position, 1400f * Time.deltaTime);
        
        
    }






}
