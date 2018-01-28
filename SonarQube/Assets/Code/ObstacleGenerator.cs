using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public Transform mine;
	public Transform barrel;
	public Transform tree;
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
		time += Time.deltaTime / 10000f * (float) GameStatus.score;
		float rnd = Random.Range(0f, 1f);
		if (time > rnd) {
			createObstacleInstance();
			time = 0f;
		}
	}

	// TODO method to create new obstacle type as prefab on world (type defines behaviour)
	// TODO method to check if we should spawn object? Need to figure out how to check this

	private void createObstacleInstance() {

		Vector3 sub_pos = GameObject.FindGameObjectWithTag("Subumarine").transform.position;
		float obstacleX = sub_pos.x + distanceAwayFromPlayer;
        var pos = Camera.main.WorldToViewportPoint(sub_pos);
        pos.x = 1.1f;
		float rnd = Random.Range(0f, 1f);
		float droprnd = Random.Range(0f, 0.5f);
		if (rnd < 0.25f) {
        	pos.y = rnd;
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(mine, gen_post,  Random.rotation);
			Debug.Log("CREATE 1");
		}
		else if (rnd >= 0.25f && rnd < 0.5f) {
        	pos.y = 1f - droprnd;
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(barrel, gen_post,  Random.rotation);
			Debug.Log("CREATE 2");
		} 
		else if (rnd >= 0.5f && rnd < 0.75f) {
        	pos.y = 1f - droprnd;

        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(tree, gen_post,  Random.rotation);
			Debug.Log("CREATE 3");
		}
		else  {
        	pos.y = 1f - droprnd;
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(barrel, gen_post,  Random.rotation);
			Debug.Log("CREATE 4");
		}
	}

}
