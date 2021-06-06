using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Principal : MonoBehaviour {


    public void Jogar(){

        SceneManager.LoadScene("InGamev1.2");


    }
    
    public void Sair(){

        Application.Quit();
    }

    public void instrucoes(){

        SceneManager.LoadScene("Instruções");

    }

    
}
