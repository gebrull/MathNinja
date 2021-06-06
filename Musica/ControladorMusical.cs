using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMusical : MonoBehaviour
{

    AudioSource audioSource;

    public AudioClip musica1;
    public AudioClip musica2;
    public AudioClip musica3;
    public AudioClip musica4;
    public AudioClip musica5;
    public AudioClip musica6;
    public AudioClip musica7;
    public AudioClip musica8;
    public AudioClip musica9;
    public AudioClip musica10;

    private bool pausado;

    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        audioSource = gameObject.GetComponent<AudioSource>();

        SeletorMusical();
        Tocar();
       

    }


    void SeletorMusical() {
        float seletor_musical = Random.Range(1, 11);

        switch (seletor_musical) {
            case 1:
                audioSource.clip = musica1;
                break;

            case 2:
                audioSource.clip = musica2;
                break;

            case 3:
                audioSource.clip = musica3;
                break;

            case 4:
                audioSource.clip = musica4;
                break;

            case 5:
                audioSource.clip = musica5;
                break;

            case 6:
                audioSource.clip = musica6;
                break;

            case 7:
                audioSource.clip = musica7;
                break;

            case 8:
                audioSource.clip = musica8;
                break;

            case 9:
                audioSource.clip = musica9;
                break;

            case 10:
                audioSource.clip = musica10;
                break;

        }
    }

    private void Update() {
        TrocarMusica();
    }



    void TrocarMusica() {
        if (!this.GetComponent<AudioSource>().isPlaying && !pausado) {
            pausado = false;
            SeletorMusical();
            audioSource.Play();
            
        }
    }


    public void Tocar(){
        pausado = false;
        audioSource.Play();
        
    }
   

   public void Parar(){
        pausado = true;
        audioSource.Pause();
        
   }

}
