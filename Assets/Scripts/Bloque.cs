using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
//		Debug.Log(collision.collider.gameObject.name);
		if (!haColisionadoConElJugador && (collision.collider.gameObject.name == "PataInferiorDerechaB" || collision.collider.gameObject.name == "PataInferiorIzquierdaB")) {
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			haColisionadoConElJugador = true;
		}
	}
}
