using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ScriptInstrucao : MonoBehaviour
{
    // Start is called before the first frame update
    public void voltar(){

        SceneManager.LoadScene("Menu");

    }

    public void proximo(){

        string nome = SceneManager.GetActiveScene().name;
        Debug.Log(nome);
        switch(nome){
            case "Instruções":
                SceneManager.LoadScene("InstruçãoV2");
            break;

            case "InstruçãoV2":
                SceneManager.LoadScene("InstruçãoV3");
            break;

            case "InstruçãoV3":
                SceneManager.LoadScene("InstruçãoV4");
            break;

            case "InstruçãoV4":
                SceneManager.LoadScene("InstruçãoV5");
            break;
        }

       



        

    }
}
