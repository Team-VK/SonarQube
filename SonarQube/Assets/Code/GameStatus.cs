using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

	public static long score;
    public Text scoreText;
    private float multiplier = 1.001;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += (long) (Time.deltaTime * 100.0f * multiplayer);
		multiplier = multiplier * multiplier;
		scoreText.text = "Score: " + score;
	}
}
