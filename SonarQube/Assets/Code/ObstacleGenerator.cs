using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public Transform mine;
	public Transform barrel;
	//public GameObject player;

	private float distanceAwayFromPlayer = 15f;
	private float time = 0f;

	// Use this for initialization
	void Start () {
		// TODO immediatelly add a obstacle -> player gets causal feedback from game mechanics
		Instantiate(mine, new Vector3(distanceAwayFromPlayer,0f,0f),  Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		// Odds of spawning a new obstacle increses as the game goes on
		// Also palyer starts to move faster and faster -> no need to worry on this class

		// TODO, generate new obstacle every 2 seconds
		time += Time.deltaTime;
		if (time > 5f) {
			createObstacleInstance();
			time = 0f;
		}
	}

	// TODO method to create new obstacle type as prefab on world (type defines behaviour)
	// TODO method to check if we should spawn object? Need to figure out how to check this

	private void createObstacleInstance() {

		Vector3 sub_pos = GameObject.FindGameObjectWithTag("Subumarine").transform.position;
		float obstacleX = sub_pos.x + distanceAwayFromPlayer;
		float rnd = Random.Range(0f, 1f);
		if (rnd < 0.25f) {
			Instantiate(mine, new Vector3(obstacleX,0f,0f),  Quaternion.identity);
			Debug.Log("CREATE 1");
		}
		else if (rnd >= 0.25f && rnd < 0.5f) {
			Instantiate(barrel, new Vector3(obstacleX,0f,0f),  Quaternion.identity);
			Debug.Log("CREATE 2");
		} 
		else if (rnd >= 0.5f && rnd < 0.75f) {

			Instantiate(barrel, new Vector3(obstacleX,0f,0f),  Quaternion.identity);
			Debug.Log("CREATE 3");
		}
		else  {
			Instantiate(barrel, new Vector3(obstacleX,0f,0f),  Quaternion.identity);
			Debug.Log("CREATE 4");
		}
	}

}
