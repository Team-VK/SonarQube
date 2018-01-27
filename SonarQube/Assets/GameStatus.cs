using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameStatus : MonoBehaviour {

	public static long score;

	// Use this for initialization
	void Start () {
		score = 0l;
	}
	
	// Update is called once per frame
	void Update () {
		score += (long) (Time.deltaTime * 1000.0f);
		Debug.Log("SCORE: " + GameStatus.score);
		
	}
}
