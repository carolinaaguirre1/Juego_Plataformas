using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    public bool tocar;
  
   private void OnTriggerEnter2D(Collider2D other)
        
    {
        
        if (other.CompareTag("Player"))
        {
            // Gameover();
            Debug.Log("tocoplayer");
            tocar = true;   
        }
    }
    private void OnTriggerExit2D(Collider2D other)

    {

        if (other.CompareTag("Player"))
        {
            // Gameover();
            Debug.Log("se fue");
            tocar = false;  
        }
    }
   
}
