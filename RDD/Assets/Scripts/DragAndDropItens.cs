using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropItens : MonoBehaviour
{
    private bool isDragging;
   

 
   void Update()
    {
    
        isDraggingVerificacao();
    }
    public void OnMouseDown() {

        if(CanvasController.instanceCanvasController.isPause != true){
            isDragging = true;
            GameController.instance.backgroundSong.Pause();
            if(GameController.instance.movimentosRestantes == 0){
                Debug.Log("Não faz nada");
            }   else{
            
                Time.timeScale = 0;
            
            }
        }        
   
}
public void OnMouseUp()
{
    if(CanvasController.instanceCanvasController.isPause != true){
        isDragging = false;
        GameController.instance.TimeGame();
        GameController.instance.backgroundSong.Play();
        Time.timeScale = 1;
    }
    
    
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
