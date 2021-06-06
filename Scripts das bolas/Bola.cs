using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    private Rigidbody rb;
    public float velocidade;
    public float rotacao;
    

	// Use this for initialization
	void Start () {
        velocidade = Random.Range(12, 15);
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * velocidade;
        rb.angularVelocity = Random.insideUnitSphere * rotacao;
    }

}
