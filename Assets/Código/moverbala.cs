using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbala : MonoBehaviour
{

     public float vel= 3.0f;
     bool direccion = false;
    // Start is called before the first frame update
    void Start()
    {

         if (Movimiento.direccionBala == true){
          direccion=true;

        }else{
           direccion=false; 
        }
        Destroy (gameObject, 0.5f);
        
    }

    // Update is called once per frame
    void Update(){

         if (direccion == true){
        if(Movimiento.direccionBala == true && Movimiento.ParardireccionBala == true){
        transform.Translate (new Vector2 (Time.deltaTime * 7,0));
        }
        if(Movimiento.direccionBala == false && Movimiento.ParardireccionBala == false){
        transform.Translate (new Vector2 (-Time.deltaTime * 7,0));
        }
        }
    }
}
