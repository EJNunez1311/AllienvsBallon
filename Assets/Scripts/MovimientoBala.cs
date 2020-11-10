using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour {

	public float Velocidad = 20;
	// Use this for initialization
	void Start(){
		Destroy (gameObject, 5);

	}

	void OnTriggerEnter(Collider col){

		if (col.CompareTag ("Globos")) {
		
			Destroy (gameObject);
			col.SendMessage ("Colision", SendMessageOptions.DontRequireReceiver);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.up * Velocidad * Time.deltaTime; 
	}
}
