using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(){
    principalScript.score +=5;
    Debug.Log( principalScript.score);
    Destroy(this.gameObject,0.1f);
    }
}
