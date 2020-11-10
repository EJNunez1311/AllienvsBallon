using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ScriptDeMovimiento : MonoBehaviour {

	Rigidbody rb;
	public float Velocidad = 8f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 VectorVelocidad;
		if (Perder.EnJuego) {
			Vector3 DireccionX = Input.GetAxis ("Vertical") * Vector3.up;
			Vector3 DireccionZ = Input.GetAxis ("Horizontal") * Vector3.forward;

			Vector3 Direccion = DireccionX + DireccionZ;
		    VectorVelocidad = Direccion * Velocidad;
		} else {
		
			VectorVelocidad = Vector3.zero;
		}
		rb.velocity = VectorVelocidad;
		
	}
}
