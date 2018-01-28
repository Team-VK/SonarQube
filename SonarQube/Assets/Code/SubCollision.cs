using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCollision : MonoBehaviour {

	public ParticleSystem particle;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		//call gameover ->
		particle.Play();
		Destroy(this.gameObject);
	}
}
