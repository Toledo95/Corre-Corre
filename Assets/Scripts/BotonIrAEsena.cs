﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonIrAEsena : MonoBehaviour {

	public string Scene = "GameScene";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		Camera.main.GetComponent<AudioSource>().Stop ();
		GetComponent<AudioSource> ().Play();
		Invoke ("CargarNivelJuego", GetComponent<AudioSource>().clip.length);

	}

	void CargarNivelJuego(){
		SceneManager.LoadScene (Scene);
	}

}
