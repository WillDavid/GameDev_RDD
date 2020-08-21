using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int movimentosRestantes = 10;
    public Text movimentoRestantesText;
    private float velocidade = 10000f;
    public static GameController instance;
    // Start is called before the first frame update

    public bool isPause;
   
    public AudioSource backgroundSong;
    public GameObject panelPause, painelPontoInicial;
    private GameObject cameraPosicao;
    


   
    void Start()
    {
       instance = this;

       painelPontoInicial = GameObject.FindGameObjectWithTag("PainelPontoInicial");
       panelPause = GameObject.Find("PausePainel");
       movimentoRestantesText.text = movimentosRestantes.ToString();
       cameraPosicao = GameObject.Find("Camera Configurada");
       painelPontoInicial.transform.position = panelPause.transform.position;
       
       
        
      
    
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


    public void Pause(){
        panelPause.transform.position = Vector2.MoveTowards(panelPause.transform.position, cameraPosicao.transform.position, velocidade * Time.deltaTime);
        Time.timeScale = 0;
    }

    public void Unpause(){
        Time.timeScale = 1;
        panelPause.transform.position = painelPontoInicial.transform.position;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            isPause = !isPause;
            if(isPause){
                Pause();
            }else{
                Unpause();
            }
        }
    }

 








}
