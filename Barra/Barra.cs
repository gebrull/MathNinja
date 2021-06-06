using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float getSizeBar(float min_val, float max_val)
    {
        return min_val / max_val;
    }

    public int getPercentBar(float min_val, float max_val, int factor)
    {
        return Mathf.RoundToInt(getSizeBar(min_val, max_val) * factor); 
    }



}
