using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espaco_de_jogo : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }




}
