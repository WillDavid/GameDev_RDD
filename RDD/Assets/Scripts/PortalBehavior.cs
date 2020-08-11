using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBehavior : MonoBehaviour
{
    // Start is called before the first frame update
   private float velocidadeRotacao = 25f; 

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.tag == "Player"){

           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
           
       } 
    }

    
    void Update()
    {
        transform.Rotate(0f,0f, 5f * velocidadeRotacao * Time.deltaTime) ;
    }
}
