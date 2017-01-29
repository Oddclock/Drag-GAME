using UnityEngine;
using System.Collections;
[RequireComponent (typeof(AudioSource))]

public class Bloque : MonoBehaviour {

	
	
	private Rigidbody2D rb;
	private GameControlScript gcs;
	

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript>();

	}
		
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Muerte") {
			Invoke ("muerte", 1);
		}

	
	}
	
		void muerte (){
			gcs.respawn ();
		}

}