﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int puntosGanados = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			gameObject.GetComponent<Renderer>().enabled = false;
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", puntosGanados);
			GetComponent<AudioSource> ().Play ();
			Destroy (gameObject,GetComponent<AudioSource> ().clip.length);
		} else {
			Destroy (gameObject);
		}


	}

}
