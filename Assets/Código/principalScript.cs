using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour{

    public static int score = 0;
    public static int vida = 3;
    public static int enemigos = 0;
    public GUISkin miSkin;
    public Texture2D logoJuego;
    int Anchopantalla;
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Anchopantalla = Screen.width/2;
       if(Input.GetKeyDown(KeyCode.Escape)){
        Application.Quit();

       } 

        Debug.Log("esto es vida " + vida);
        Debug.Log("esto es score " + score);
        Debug.Log("esto es enemigos " + enemigos);
        
    }
 
    void OnGUI (){

        GUI.skin = miSkin;
        GUI.Label(new Rect (20, 20, 150, 80),"Vida: "+vida.ToString(),"estiloScore");
        GUI.Label(new Rect (100, 20, 150, 80),"Score: "+score.ToString(),"estiloScore");
        GUI.Label(new Rect (180, 20, 150, 80),"Enemigos: "+enemigos.ToString(),"estiloScore");
        GUI.Label(new Rect(Anchopantalla-80,20,200,100),"Nombre Juego", "estiloTitulo");

        GUI.DrawTexture(new Rect(Screen.width-80,20,64,64),logoJuego);
    }
}
