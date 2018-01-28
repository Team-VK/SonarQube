using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour {
	public float fallspeed = 0.1f;	

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - fallspeed * Time.deltaTime, 0f );
		
        this.transform.position = Vector3.MoveTowards(this.transform.position, 
        	new Vector3(this.transform.position.x, this.transform.position.y - fallspeed * Time.deltaTime, 0f ), 
        	fallspeed * Time.deltaTime);
	}
}
