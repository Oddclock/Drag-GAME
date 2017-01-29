using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	private Vector3 respawn_point;
	public GameObject player;
    public GameObject player2;
    void Start(){
		respawn_point = player.transform.position;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.transform.position = respawn_point;
        }
    }
    public void respawn (){
		player.transform.position = respawn_point;
	}

}
