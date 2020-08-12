using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaoScript : MonoBehaviour
{
    public static PortaoScript rotacao;
    private bool taGirado = false;
    public GameObject portao;
   
    

    
    // Start is called before the first frame update
    void Start()
    {
        rotacao = this;
    }

    void Update(){
        checkEstadoPortao();
    }

    public void RotatacaoPortao(){
        taGirado = true;
        if(taGirado == true){
            
            transform.Rotate(new Vector3(0,0,90));
     
        }

        taGirado = false;
        
    }

    void checkEstadoPortao(){
        if(transform.eulerAngles.z == 0 || transform.eulerAngles.z == 180){
               portao.tag = "Untagged";
            }else{
                portao.tag = "Parede";
            }
    }
}
