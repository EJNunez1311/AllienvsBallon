using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarGlobos : MonoBehaviour {


	public float InstanceRate = 2;
	public GameObject GloboAzul;
	public GameObject GloboRojo;
	public GameObject GloboVerde;
	// Use this for initialization
	IEnumerator Start () {

		while (true) {
			Instantiate (GloboAzul, transform.position, Quaternion.identity);
			Instantiate (GloboRojo, transform.position, Quaternion.identity);
			Instantiate (GloboVerde, transform.position, Quaternion.identity);
			Instantiate (GloboAzul, transform.position, Quaternion.identity);
		
			yield return new WaitForSeconds (InstanceRate);
		}
		
	}

}
