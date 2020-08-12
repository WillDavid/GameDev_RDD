using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float velocidadePlayer;
    private bool direcao = true;

    private Rigidbody2D rb;

    public SpriteRenderer sprite;
    

    public Transform portalA;
    public Transform portalB;

    private bool invertePlayer = false;
   

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        movimentacaoPlayer();
        
    }
    void movimentacaoPlayer(){

        if(direcao == true){
            transform.Translate(Vector2. right * velocidadePlayer * Time.deltaTime);
            
            
        }else{
           
            transform.Translate(Vector2. left * velocidadePlayer * Time.deltaTime);
            
            
            
            
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Parede" && direcao == true){
            
            direcao = false;
            FlipX();
            
        }else if(other.collider.tag == "Parede" && direcao == false){
            
            direcao = true;
            FlipX();
            
        }

        if(other.collider.tag == "Trap"){
            Destroy(gameObject, 0.5f);
            
        }
    
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Trampolim"){


            if(rb.gravityScale == 1){
                rb.velocity = new Vector2(0f, 5f);
            }else if(rb.gravityScale == -1) {
                rb.velocity = new Vector2(0f, -5f);
            }                   
          
        }

        if(other.gameObject.tag == "ModiGravi"){
            
            

            
                rb.gravityScale = -1;
                invertePlayer = true;
                
            

            
            
               
            
            
        }
    }

     void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "PortalA"){
            transform.position = portalB.transform.position;
        }
        if(other.gameObject.tag == "ModiGravi"){

               if(invertePlayer == false){
                   FlipY();
               }  
        }

        if(other.gameObject.tag == "Botao"){
            PortaoScript.rotacao.RotatacaoPortao();
        }

    }

    void FlipX(){
        sprite.flipX = !sprite.flipX;
    }

    void FlipY(){
        sprite.flipY = !sprite.flipY;
    }
}
