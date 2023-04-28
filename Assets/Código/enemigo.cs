using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
 public string clonBala;
 float velocidadEnemigo = 1f;//IA
 float distanciaPlayer = 4f;//IA
 Vector3 posicionInicial;//IA

 public GameObject Player; //IA

 void Start(){

    Player = GameObject.FindGameObjectWithTag("Player"); //IA
    posicionInicial = transform.position; //IA

 }

 void Update(){

    Vector3 Objetivo = posicionInicial;//IA
    float distancia = Vector3.Distance(Player.transform.position, transform.position);

    if(distancia < distanciaPlayer){//IA

        Objetivo = Player.transform.position;//IA
    }

    float velocidadFija = velocidadEnemigo*Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, Objetivo, velocidadFija);

    Debug.DrawLine(transform.position,Objetivo,Color.green);
    
 }

 void OnTriggerEnter2D (Collider2D col){
    clonBala = col.gameObject.name; 

    if(clonBala == "balafuego(Clone)"){
        principalScript.enemigos++;
        Destroy(this.gameObject, 0.3f);
    }

    if(clonBala == "personaje"){
        principalScript.vida--;
        Player.transform.position = new Vector2 (-4.13f,-1.38f);

    }

    }
}