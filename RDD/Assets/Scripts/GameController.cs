﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int movimentosRestantes = 10;
    public Text movimentoRestantesText;
    public static GameController instance;
    public AudioSource backgroundSong;
   
    


   
    void Start()
    {
       instance = this;
       movimentoRestantesText.text = movimentosRestantes.ToString();

       
       
        
      
    
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
}
