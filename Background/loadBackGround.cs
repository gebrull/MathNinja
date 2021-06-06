using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadBackGround : MonoBehaviour
{


    public Sprite fundo1;
    public Sprite fundo2;
    public Sprite fundo3;
    public Sprite fundo4;
    public Sprite fundo5;
    public Sprite fundo6;
    public Sprite fundo7;
    public Sprite fundo8;
    public Sprite fundo9;
    public Sprite fundo10;



    // Start is called before the first frame update
    void Start()
    {
        float fundo = Random.Range(1,11);

        //Debug.Log("background " + numbero);

        switch(fundo){
            case 1:
                this.GetComponent<SpriteRenderer>().sprite = fundo1;
            break;

            case 2:
                this.GetComponent<SpriteRenderer>().sprite = fundo2;
            break;

            case 3:
                this.GetComponent<SpriteRenderer>().sprite = fundo3;
            break;

            case 4:
                this.GetComponent<SpriteRenderer>().sprite = fundo4;
            break;

            case 5:
                this.GetComponent<SpriteRenderer>().sprite = fundo5;
            break;

            case 6:
                this.GetComponent<SpriteRenderer>().sprite = fundo6;
            break;

            case 7:
                this.GetComponent<SpriteRenderer>().sprite = fundo7;
            break;

            case 8:
                this.GetComponent<SpriteRenderer>().sprite = fundo8;
            break;

            case 9:
                this.GetComponent<SpriteRenderer>().sprite = fundo9;
            break;

            case 10:
                this.GetComponent<SpriteRenderer>().sprite = fundo10;
            break;
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
