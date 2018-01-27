using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour {
	public Transform newParent;

	// Use this for initialization
	void Start() {
		Debug.Log (this.transform.rotation);
		this.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
	}

	// Update is called once per frame
	void Update () {
		
		this.transform.position = new Vector3(this.transform.position.x + 0.1f * Time.deltaTime,
			this.transform.position.y + 0.1f * Time.deltaTime, 0f);
		this.transform.localScale = new Vector3 (this.transform.localScale.x + 0.01f * Time.deltaTime,
			this.transform.localScale.y + 0.01f * Time.deltaTime,
			this.transform.localScale.z + 0.01f * Time.deltaTime);
	}

	/*
	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
		if (collision.relativeVelocity.magnitude > 2)
			audioSource.Play();
	}
	*/

}
