using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortador : MonoBehaviour {

    public GameObject cortador;
    private Touch touch;
    private Vector3 posicao;
   // private int velocidade = 1000000;
    

    // Use this for initialization
    void Update () {
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
            *
            /*

            if (Input.touchCount == 1)
            {
                cortador.SetActive(true);
                touch = Input.GetTouch(0);
                float xPosicao = -9 + 18 * touch.position.x / Screen.width;
                float yPosicao = -4 + 10 * touch.position.y / Screen.height;
                transform.position = new Vector3(xPosicao, yPosicao, 0);

            }
            else
            {
                cortador.SetActive(false);
            }
            */
        
    }

    

}
