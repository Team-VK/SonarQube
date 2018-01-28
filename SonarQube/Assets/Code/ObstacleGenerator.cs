using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public Transform mine;
	public Transform barrel;
	public Transform tree;
	public Transform ring;
	//public GameObject player;

	private float time = 0f;

	// Use this for initialization
	void Start () {
		Instantiate(mine, Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.5f, 0f)),  Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		// Odds of spawning a new obstacle increses as the game goes on
		// Also palyer starts to move faster and faster -> no need to worry on this class

		time += Time.deltaTime / 10000f * (float) GameStatus.score;
		float rnd = Random.Range(0f, 1f);
		if (time > rnd) {
			createObstacleInstance();
			time = 0f;
		}
	}

	private void createObstacleInstance() {

		Vector3 sub_pos = GameObject.FindGameObjectWithTag("Subumarine").transform.position;
        var pos = Camera.main.WorldToViewportPoint(sub_pos);
        pos.x = 1.1f;
        pos.y = 0f;
		float rnd = Random.Range(0.0f, 1.0f);
		float droprnd = Random.Range(0f, 0.5f);
		if (rnd < 0.25f) {
        	pos.y = Random.Range(0.5f, 1.0f);
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(mine, gen_post,  Random.rotation);
		}
		else if (rnd >= 0.25f && rnd < 0.5f) {
        	pos.y = 1f - droprnd;
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(barrel, gen_post,  Random.rotation);
		} 
		else if (rnd >= 0.5f && rnd < 0.75f) {
        	pos.y = 1f - droprnd;
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(tree, gen_post,  Random.rotation);
		}
		else  {
        	pos.y = Random.Range(0.0f, 1.0f);
        	var gen_post = Camera.main.ViewportToWorldPoint(pos);
			Instantiate(ring, gen_post,  Random.rotation);
		}
	}

}
