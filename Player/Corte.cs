using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corte : MonoBehaviour {

    
    private Touch touch;
    private Vector3 posicao;
    private int velocidade = 100000;
    public GameObject cortador;
   
   /*
    public AudioSource musica;


    public void Start(){

        musica.Play();

    }

*/


    void CorteUpdate()
    {


        cortador.SetActive(true);
        touch = Input.GetTouch(0);
        float xPosicao = -9 + 18 * touch.position.x / Screen.width;
        float yPosicao = -4 + 10 * touch.position.y / Screen.height;
        cortador.GetComponent<Rigidbody>().position = new Vector3(xPosicao, yPosicao, 0);

    }
         
    void CorteIntocavel()
    {
        
        cortador.GetComponent<Rigidbody>().position = new Vector3(0, 0, 0);
        CorteUpdate();
    }


    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount == 1 || Input.GetMouseButton(1))
        {
            CorteIntocavel();            
        }
        else
        {
            cortador.SetActive(false);
        }
      
        /*
        if (Input.GetMouseButton(1))
        {
            cortador.SetActive(true);
            posicao = Input.mousePosition;
            posicao = Camera.main.ScreenToWorldPoint(posicao);
            transform.position = Vector3.Lerp(transform.position, posicao, velocidade);

        }
        else
        {
            cortador.SetActive(false);
        }
        */
    }

    
}
