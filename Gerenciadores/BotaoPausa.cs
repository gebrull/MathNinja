using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BotaoPausa : MonoBehaviour
{
    private bool gameIsPaused = false;
    public GameObject pausa;
    public GameObject resume;
    public AudioSource musica;
    public ControladorMusical controlador;

    void Start(){
        controlador = musica.GetComponent<ControladorMusical>();
        controlador.Tocar();
        //musica.Play();

    }




    public void Pausa(){
        if(!gameIsPaused){
            gameIsPaused = true;
            pausa.SetActive(false);
            resume.SetActive(true);
            Debug.Log("PAUSA");
            controlador.Parar();
            //musica.Pause();
            Time.timeScale = 0f;
            
        }
    } 


    public void Resume(){
        if(gameIsPaused){
            gameIsPaused = false;
            resume.SetActive(false);
            pausa.SetActive(true);
            Debug.Log("RESUME");
            controlador.Tocar();
            //musica.Play();
            Time.timeScale = 1f;
            
        }
    }


}
