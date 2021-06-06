using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestruirPeloContato : MonoBehaviour {

    public GameObject explosao1;
    public GameObject explosao2;
    public GameObject explosao3;
    public GameObject explosao4;
    public GameObject explosao5;
    public GameObject explosao6;
    public GameObject explosao7;
    public GameObject explosao8;
    public GameObject explosao9;
    public GameObject spawn;
    public GameObject perdeuAudio;
    public GameObject frenesi;
    public TempoRestante tempoRestante;
    public GameObject objetoJogador;
    public GameObject botaoPause;


    public Text derrota;
    public Text acertos;
    public Text quest;
    private int placarAcertos = 0;
    private int soma;
    private int resultado;
    private int primeiroTermo;
    private int segundoTermo;
    private int numeroUpdates = 0;
    public bool verificacaoDeDerrota = false;
    private int numeroAcertos = 0;



    private void Start()
    {
        soma = 0;
        ScoreUpdate();
        derrota.rectTransform.position = new Vector3(0, 10, 0);
    }

    private void Update()
    {
        if (verificacaoDeDerrota)
        {
            //if (Input.touchCount == 2 || Input.GetButtonDown("Fire1"))          //LINHA DE TESTE
            if (Input.touchCount == 2)                                          //LINHA PRA COMPILAR
            {
               // Debug.Log("RESTART");
                //SceneManager.LoadScene("Teste de objetos");             //CENA DE TESTE
                SceneManager.LoadScene("InGamev1.2");
                return;
            }
        }
    }


    void NovaConta()
    {
        int variavel_decisao = Random.Range(1,5);
        int auxiliar = 0;
        switch (variavel_decisao)
        {
            case 1:                                         //CASO DE SOMA
                primeiroTermo = Random.Range(1, 9);
                segundoTermo = Random.Range(1, 9);
                resultado = primeiroTermo + segundoTermo;
                break;
            case 2:                                         //CASO DE SUBTRAÇÃO
                primeiroTermo = Random.Range(1, 9);
                segundoTermo = Random.Range(1, 9);
                if(primeiroTermo < segundoTermo){
                    auxiliar = primeiroTermo;
                    primeiroTermo = segundoTermo;
                    segundoTermo = primeiroTermo; 
                }
                resultado = primeiroTermo - segundoTermo;
                if(resultado == 0){
                    primeiroTermo++;
                    resultado++;
                }
                break;

            case 3:                                         //CASO DE MULTIPLICAÇÃO
                primeiroTermo = Random.Range(1, 9);
                segundoTermo = Random.Range(1, 9);
                resultado = primeiroTermo * segundoTermo;
                break;

            case 4:                                         //CASO DE DIVISÃO
                primeiroTermo = Random.Range(1, 9);
                segundoTermo = Random.Range(1, 9);
                resultado = primeiroTermo * segundoTermo;
                auxiliar = primeiroTermo;
                primeiroTermo = resultado;
                resultado = auxiliar;
                break;

        }    
            
        QuestUpdate(variavel_decisao);
        
    }

    void QuestUpdate(int variavel_decisao)
    {
        Debug.Log("Variavel de decisao  "+variavel_decisao);

        switch (variavel_decisao)
        {
            case 1:                                         //CASO DE SOMA
                quest.text = primeiroTermo + " + " + segundoTermo;
                break;
            case 2:                                         //CASO DE SUBTRAÇÃO
                quest.text = primeiroTermo + " - " + segundoTermo;
                break;

            case 3:                                         //CASO DE MULTIPLICAÇÃO
                quest.text = primeiroTermo + " x " + segundoTermo;
                break;

            case 4:                                         //CASO DE DIVISÃO
                quest.text = primeiroTermo + " / " + segundoTermo;
                break;

        }
        
        tempoRestante.resetaTempo();
        if (numeroUpdates != 0)
        {
            tempoRestante.paraRelogio();
            tempoRestante.tocaAcerto();
            numeroAcertos++;
            placarAcertos++;
            acertos.text = "Acertos: "+placarAcertos+" ";
            Debug.Log("ACERTOU"+placarAcertos);            
            Debug.Log(numeroAcertos);
            if(numeroAcertos == 5){
                int randomico = Random.Range(1,4);
                Debug.Log("NUMERO RANDOM"+randomico);
                if(randomico != 8){
                    Instantiate(frenesi, frenesi.transform.position, frenesi.transform.rotation);
                    numeroAcertos = 0;
                }
            }
           
        }
        else
        {
            numeroUpdates = 1;
        }
    }




           
    void ScoreUpdate()
    {
        if(soma == resultado)
        {
           // Debug.Log("GANHOU");
            soma = 0;
            NovaConta();
        }
        else
        {
            if (soma > resultado)
            {
               // Debug.Log("PERDEU");
                derrota.text = "O VALOR PASSOU!\nRESULTADO: " + resultado;
                botaoPause.SetActive(false);
                tempoRestante.paraContador();
                tempoRestante.paraRelogio();
                if(verificacaoDeDerrota == false){
                    Destroy(Instantiate(perdeuAudio), 4);
                    derrota.rectTransform.position = new Vector3(0, 0, 0);
                    spawn.SetActive(false);
                    verificacaoDeDerrota = true;
                    Destroy(objetoJogador);
                }
                

            }

        }       
        //scoreText.text = "" + soma;
    }

    public int retornaSoma()
    {
        return soma;
    }

    public int retornaResultado()
    {
        return resultado;
    }

    public void setDerrota()
    {
        verificacaoDeDerrota = true;
    }

    public bool retornaVerificacao()
    {
        return verificacaoDeDerrota;
    }

    void OnTriggerEnter(Collider other)
     {
        if(other.tag == "BOLA1")
        {
            Instantiate(explosao1, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 1;
            ScoreUpdate();
        }
        if (other.tag == "BOLA2")
        {
            Instantiate(explosao2, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 2;
            ScoreUpdate();
        }
        if (other.tag == "BOLA3")
        {
            Instantiate(explosao3, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 3;
            ScoreUpdate();
        }
        if (other.tag == "BOLA4")
        {
            Instantiate(explosao4, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 4;
            ScoreUpdate();
        }
        if (other.tag == "BOLA5")
        {
            Instantiate(explosao5, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 5;
            ScoreUpdate();
        }
        if (other.tag == "BOLA6")
        {
            Instantiate(explosao6, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 6;
            ScoreUpdate();
        }
        if (other.tag == "BOLA7")
        {
            Instantiate(explosao7, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 7;
            ScoreUpdate();
        }
        if (other.tag == "BOLA8")
        {
            Instantiate(explosao8, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 8;
            ScoreUpdate();
        }
        if (other.tag == "BOLA9")
        {
            Instantiate(explosao9, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            soma += 9;
            ScoreUpdate();
        }


    }

                                    	
}
