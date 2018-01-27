using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour {

	// Use this for initialization
	void Start() {
		Debug.Log (this.transform.rotation);
		//Vector2 mouseOnScreen = (Vector2)Input.mousePosition; //Direction to shoot the projectile at
		this.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
		//this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0f));
		//this.GetComponentInParent<Light> = new Vector3(1f, 1f, 0f);
		//this.GetComponent<Rigidbody>().velocity = new Vector3(1f, 1f, 0f);
		//this.GetComponent<Rigidbody>().AddForce(Quaternion.Euler(this.transform.rotation)*this.transform.forward * 0.1f);

	}

	// Update is called once per frame

	void Update () {
		this.transform.localScale = new Vector3 (this.transform.localScale.x+0.1f, this.transform.localScale.y+0.1f, this.transform.localScale.z+0.1f);
	}

	/*
	 *
	void FixedUpdate(){
		direction = (finalPosition - transform.position).normalized;  // Get the normalized direction to target
		float distance = Vector3.distance (finalPosition,  transform.position); // Get distance to target
		float speed = Mathf.Clamp(distance*speedCoefficient, 0f, maxSpeed);   // Keep speed under limit
		rigidbody.velocity = direction *speed; // Make the speed dependent on the distance to the target
	}

	*/
	 /*
	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}
		if (collision.relativeVelocity.magnitude > 2)
			foreach (Component c in this.GetComponents) {
				Destroy(c);
			}
	}
	*/

}
