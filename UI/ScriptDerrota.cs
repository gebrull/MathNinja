using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptDerrota : MonoBehaviour
{
    // Start is called before the first frame update
    public void Recomeca(){

        SceneManager.LoadScene("InGamev1.2");

    }

    public void Volta(){

        SceneManager.LoadScene("Menu");

    }
}
