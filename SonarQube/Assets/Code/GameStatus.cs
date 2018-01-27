using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

	public static float score;
    public Text scoreText;
    private float multiplier = 1.001f;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += (Time.deltaTime * multiplier);
		multiplier = multiplier + 0.001f;
		scoreText.text = "Score: " + (long) score  + " " + multiplier;
	}
}
