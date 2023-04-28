using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Speed = 2f;
    public bool ActivaSalto = true;
    public float Salto = 4.5f;

    public Animator controlAnimacion;
    public static bool direccionBala = false;
    public static bool ParardireccionBala = false;
    
    void Awake(){
     DontDestroyOnLoad(gameObject);
    }
    
  
   Rigidbody2D miCuerpoRigido;

   
    void Start()
    {
        miCuerpoRigido = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update(){

        if(principalScript.vida > 0){
        float H = Input.GetAxis ("Horizontal")*Speed;
            H *= Time.deltaTime;
            H *= Speed;
            transform.Translate(H,0,0);   


            //INPUTS CONTROL NO PREDEFINIDOS
            if(Input.GetKey(KeyCode.Space) && ActivaSalto == true ){
                GetComponent<Rigidbody2D>().AddForce (new Vector2(0,Salto),ForceMode2D.Impulse);     
                ActivaSalto = false; 
            }
            if(Input.GetKeyDown(KeyCode.RightArrow) ||Input.GetKeyDown(KeyCode.D) ){
                transform.localScale = new Vector3 (1,1,1);
                controlAnimacion.SetBool("activarCaminar",true);
                direccionBala = true;
                ParardireccionBala = true;
                parallax.DireccionPersonaje = "derecha";
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow) ||Input.GetKeyDown(KeyCode.A) ){
                transform.localScale = new Vector3 (-1,1,1);
                controlAnimacion.SetBool("activarCaminar",true);
                direccionBala = false;
                 parallax.DireccionPersonaje = "izquierda";
            }

            if(Input.GetKeyUp(KeyCode.RightArrow) ||Input.GetKeyUp(KeyCode.D) ){
                controlAnimacion.SetBool("activarCaminar",false);  
                ParardireccionBala = false;
                 parallax.DireccionPersonaje = "parado";        
            }
            if(Input.GetKeyUp(KeyCode.LeftArrow) ||Input.GetKeyUp(KeyCode.A) ){           
                controlAnimacion.SetBool("activarCaminar",false);
                ParardireccionBala = true;
                 parallax.DireccionPersonaje = "parado";
            }
    }
       
    }

 void OnCollisionEnter2D(){   
    ActivaSalto = true;
 }
        
}
