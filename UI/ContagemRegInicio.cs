using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContagemRegInicio : MonoBehaviour {

    public Text displayCount;

    public float tempo;
    
	void Update () {
		
        if(tempo > 0)
        {
            tempo -= Time.deltaTime;
            displayCount.text = ""+(int)(tempo + 1);
        }
        else
        {
            displayCount.text = "COMEÇOU!";
            Destroy(displayCount, 1.5f);
        }





	}
}
