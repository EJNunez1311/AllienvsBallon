using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperGlobo : MonoBehaviour {

	public AudioSource au;
	public GameObject Globos;
	// Use this for initialization
	void Start(){
		au = Camera.main.GetComponent<AudioSource>();
	}
	void Colision()
	{
		au.Play ();
		Puntaje.puntajeActual.ActualizarPuntaje ();
		Destroy (gameObject);
	}

}
