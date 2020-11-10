using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

	public Transform Lanzador;
	public AudioSource au;
	public GameObject DisparoPrefab;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")){
			au.Play();
			Instantiate (DisparoPrefab, Lanzador.position, DisparoPrefab.transform.rotation);
	}

	}
}
