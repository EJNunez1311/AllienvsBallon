using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GloboScript : MonoBehaviour {

	public float Velocidad = 1f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = Vector3.up * Velocidad + Vector3.forward * Random.Range(-5,5);
		
	}



	
	// Update is called once per frame
	void Update () {

	}
}
