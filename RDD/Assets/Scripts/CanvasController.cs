using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasController : MonoBehaviour
{

    public bool isPause;

    public static CanvasController instanceCanvasController;

    public GameObject panelPause, painelPontoInicial;
    private GameObject cameraPosicao;

    private float velocidade = 10000f;
    void Start()
    {
        instanceCanvasController = this;
        painelPontoInicial = GameObject.FindGameObjectWithTag("PainelPontoInicial");
        panelPause = GameObject.Find("PausePainel");
        cameraPosicao = GameObject.Find("CameraConfigurada");
        painelPontoInicial.transform.position = panelPause.transform.position;
       
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
