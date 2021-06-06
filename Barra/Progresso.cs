using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Progresso : MonoBehaviour {


    public Barra statusBarra;
    public DestruirPeloContato destroi;


    public GameObject barraProgresso;
    public Text textoProgresso;


    public float maxProgresso;
    public float atualProgresso;


    private bool ultimaBola = false;
	// Use this for initialization
	void Start () {
        statusBarra = this.gameObject.GetComponent<Barra>();
        barraProgresso.transform.localScale = new Vector3(barraProgresso.transform.localScale.x, statusBarra.getSizeBar(destroi.retornaSoma(), destroi.retornaResultado()), barraProgresso.transform.localScale.z);
        textoProgresso.text = "" + destroi.retornaSoma();
    }
	
	// Update is called once per frame
	void Update () {
        
        if(!destroi.retornaVerificacao())
        {
            barraProgresso.transform.localScale = new Vector3(barraProgresso.transform.localScale.x, statusBarra.getSizeBar(destroi.retornaSoma(), destroi.retornaResultado()), barraProgresso.transform.localScale.z);
            textoProgresso.text = "" + destroi.retornaSoma();
        }
        else
        {
            if (!ultimaBola)
            {
                barraProgresso.transform.localScale = new Vector3(1, 1, 1);
                textoProgresso.text = "" + destroi.retornaSoma();
                ultimaBola = true;
            }

            //Debug.Log("ACABOU");
            atualProgresso = 0;
        }



	}
}
