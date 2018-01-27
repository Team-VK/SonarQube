using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroll : MonoBehaviour {

	public float sideScrollSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Increase players x with parameterized side scrolling speed
		var sub_pos = GameObject.FindGameObjectWithTag("Player").transform.position;
		var sub_pos.x += sideScrollSpeed * Time.deltaTime;
		GameObject.FindGameObjectWithTag("Player").transform.position = sub_pos;
	}
}
