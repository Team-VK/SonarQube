using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var speed = 2f;

		var sub_pos = GameObject.FindGameObjectWithTag("subumarine").transform.position;
		var mine_pos = this.transform.position;

		// example sub_pos.x
		// example sub_pos.y

		var direction = sub_pos - mine_pos;	
	}
}
