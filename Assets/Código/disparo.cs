using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
   public GameObject bala; 

    // Update is called once per frame
    void Update() {
    if (Input.GetKeyDown(KeyCode.X)== true){  
    
        Instantiate (bala,new Vector2 (transform.position.x,transform.position.y), transform.rotation);
        //
        
    }
}
}
