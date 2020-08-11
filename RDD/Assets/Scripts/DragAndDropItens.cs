using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropItens : MonoBehaviour
{
    private bool isDragging;
    private bool isPaused = false;

 
   void Update()
    {
    
        isDraggingVerificacao();
    }
    public void OnMouseDown() {
         
        isDragging = true;
        GameController.instance.backgroundSong.Pause();
       
       
    

    if(GameController.instance.movimentosRestantes == 0){
        Debug.Log("Não faz nada");
    }else{
        Time.timeScale = 0;
    }
        
        isPaused = true;
        

        

    
}
public void OnMouseUp()
{
    isDragging = false;

    Time.timeScale = 1;
    isPaused = false;
    GameController.instance.TimeGame();
    GameController.instance.backgroundSong.Play();
    
}
   
    


    void isDraggingVerificacao(){

        if(GameController.instance.movimentosRestantes < 0){
            Debug.Log("Não faz nada");
            }else if(GameController.instance.movimentosRestantes > 0 && isDragging){
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);   
        } 
    }
}
