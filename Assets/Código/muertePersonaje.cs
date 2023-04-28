using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muertePersonaje : MonoBehaviour{

    public GameObject personaje;
  
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(){
        Debug.Log("¡Has muerto!");
    principalScript.vida--;
    personaje.transform.position = new Vector2(-4.13f,-1.38f);
    /*personaje.transform.position = new Vector3 (-9, -2, 0);
    gestorSonido.GetComponent<audioManager>().deadSE();*/
    }
}
