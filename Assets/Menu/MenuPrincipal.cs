using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void EmpezarJuego(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);//despues de caragr el menu carga la escena principal del juego
	}

	public void CerrarJuego(){
		Application.Quit ();
		Debug.Log("Exit");
	}
}
