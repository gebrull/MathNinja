using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TempoRestante : MonoBehaviour {

    public Text displayTempo;
    public Text derrotaText;
    public GameObject spawnBolinhas;
    public float tempoInicial;    
    public float startWait;

    public GameObject acerto;
    AudioSource audios;
    public GameObject perdeuAudio;
    public GameObject pausa;

    private float tempoRestante;
    private int count;
    private bool perdeu = false;


    private void Start()
    {
        audios = GetComponent<AudioSource>();
        tempoRestante = tempoInicial;
        displayTempo.text = "TEMPO: " + tempoRestante;
        StartCoroutine(ComecarContador());
    }

    private void Update()
    {
        if (perdeu)
        {            
            //if (Input.touchCount == 2 || Input.GetButtonDown("Fire1"))          //LINHA DE TESTE
            if (Input.touchCount == 2)                                          //LINHA PRA COMPILAR
            {
               Debug.Log("RESTART");
              // SceneManager.LoadScene("Teste de objetos");             //CENA DE TESTE
               SceneManager.LoadScene("InGamev1.2");
               return;
            }            
        }
    }

    void tocaRelogio()
    {
        audios.Play(0);
    }

    public void paraRelogio()
    {
        audios.Stop();
    }

   
    public void paraContador()
    {
        count = 100;
    }



    public void resetaTempo()
    {
        tempoRestante = tempoInicial;
    }

    public void tocaAcerto()
    {
        Destroy(Instantiate(acerto), 4.0f);
    }

    IEnumerator ComecarContador()
    {
        yield return new WaitForSeconds(startWait);

        for (count = 0; count < 100 ; )
        {
            if (tempoRestante > 0)
            {
                tempoRestante -= 1;
                displayTempo.text = "tempo: " + (int)(tempoRestante + 1);
                if(tempoRestante == 4) //PQ O TEMPO TÁ 1 SEGUNDO ATRASADO NO DISPLAY
                {
                    audios.Play(0);
                }
                
            }
            else
            {
                displayTempo.text = "";
                derrotaText.text = "VOCE PERDEU\nACABOU O TEMPO! ";
                Destroy(Instantiate(perdeuAudio), 4);
                spawnBolinhas.SetActive(false);
                pausa.SetActive(false);
                count = 100;
                perdeu = true;
                derrotaText.rectTransform.position = new Vector3(0, 0, 0);
            }


            

            yield return new WaitForSeconds(1);
        }


    }
}
