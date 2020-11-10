using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class VidaNaveScript : MonoBehaviour {

	public float tiempoinicial = 0;
	public int periodo = 15;
	public int CantidadDeVidas = 3;
	int seconds;

	public Image img;

	public Sprite TresVidas, DosVidas, UnaVida;

	void Start(){
		CantidadDeVidas = 3;
		img.sprite = TresVidas;

	}
	void Update(){
		tiempoinicial += Time.deltaTime;
		seconds = (int)(tiempoinicial % 60);
		if (seconds == periodo) {
			CantidadDeVidas--;
			tiempoinicial = 0;
			Damage ();
		}


	}

	public void Damage(){
		
		if (CantidadDeVidas == 3) {
			img.sprite = TresVidas;
		} else if (CantidadDeVidas == 2) {
			img.sprite = DosVidas;
		} else if (CantidadDeVidas == 1) {
			img.sprite = UnaVida;
		} else {
		  SendMessage ("perder",SendMessageOptions.DontRequireReceiver);
			
		}

	}

}
