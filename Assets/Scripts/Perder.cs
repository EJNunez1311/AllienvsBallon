using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perder : MonoBehaviour {

	public GameObject MenuPerder;
	public static bool EnJuego;

	// Use this for initialization
	void Start () {
		EnJuego = true;
		MenuPerder.SetActive(false);
	}

	public void Reiniciar(){
		SceneManager.LoadScene (0);

	}

	public void perder(){
		EnJuego = false;
		MenuPerder.SetActive(true);
	}

}
