using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip clipMenu;
    public AudioClip lanzaBala;

    private AudioSource hiloMusical;
    private Scene escenaActual;

    void Awake (){
        DontDestroyOnLoad(this.gameObject);
    }
   
    void Start()
    { hiloMusical = GetComponent<AudioSource>(); 
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
        
    }

   
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "start"){
            hiloMusical.pitch = 1f;
        
    }else if(escenaActual.name == "nivel1"){
        hiloMusical.pitch = 1.5f;
    }

    }
    

}
