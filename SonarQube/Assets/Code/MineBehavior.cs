using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("MINE BEHAVIOR COLLISION");
		if(col.gameObject.name == "PushProjectile")
		{
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("MINE BEHAVIOR COLLIDER");
		if(col.gameObject.name == "PushProjectile")
		{
			Destroy (this.gameObject);
		}
	}
}
