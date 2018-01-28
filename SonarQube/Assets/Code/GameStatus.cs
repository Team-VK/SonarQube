using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

	public static float score;
    public Text scoreText;
	public Text gameOver;
    private float multiplier = 1.001f;
	GameObject subumarine;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += (Time.deltaTime * multiplier);
		multiplier = multiplier + 0.001f;
		scoreText.text = "Score: " + (long) score  + " " + multiplier;

		subumarine = GameObject.FindWithTag("Subumarine");
		Debug.Log (subumarine);

		if (subumarine == null) {
			Debug.Log ("Kräsh!");
			Gameover();
		}
	}

	void Gameover() {
		Time.timeScale = 0.0F;
		gameOver.text = "GAME OVER!";
	}
}
