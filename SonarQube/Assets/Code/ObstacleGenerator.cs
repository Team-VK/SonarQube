using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public Transform mine;
	//public GameObject player;


	// Use this for initialization
	void Start () {
		// TODO immediatelly add a obstacle -> player gets causal feedback from game mechanics

		//mine = Instantiate((GameObject) Resources.Load("Mine"));
/*
		var spawnPos = player.transform.position;
		spawnPos.x += 0;
//		var go = Instantiate((GameObject) Resources.Load("Mine"), spawnPos,  Quaternion.Euler(0, 0, 0));
		var go = Instantiate(mine, spawnPos,  Quaternion.identity);
		Debug.Log("Something started: " + this.transform.position.x);
*/
		//GameObject player = GameObject.FindWithTag("Player");
		 //GameObject instance = Instantiate(Resources.Load("Mine", typeof(GameObject))) as GameObject;
		var go = Instantiate(mine, new Vector3(2f,0f,0f),  Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		// Odds of spawning a new obstacle increses as the game goes on
		// Also palyer starts to move faster and faster -> no need to worry on this class

	}

	// TODO method to create new obstacle type as prefab on world (type defines behaviour)
	// TODO method to check if we should spawn object? Need to figure out how to check this
}
