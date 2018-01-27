using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour {

	public Transform projectile;
	Light sonar;
	Plane crosshair;

	void Start() {
		sonar = GameObject.Find("Sonar").GetComponent<Light>();
		crosshair = GameObject.Find("Crosshair").GetComponent<Plane>();
	}
	
	void Update() {
		Vector2 positionOnScreen = sonar.transform.position;
		Vector2 crosshairPosition = (Vector2) crosshair.ClosestPointOnPlane((Vector3) positionOnScreen);
		float angle = AngleBetweenTwoPoints(positionOnScreen, crosshairPosition);
		if(angle > 55) {
			angle = 55;
		}
		else if(angle < -55) {
			angle = -55;
		}
			
		Quaternion rot = Quaternion.Euler (new Vector3 (angle, 90, 0f));
		sonar.transform.rotation = rot;

		if (Input.GetKeyDown ("space")) {
			sendSonarWave(positionOnScreen, rot);
			Debug.Log (rot);
		}
	}

	//Sends a sonar wave in the direction pointed by the sonar device
	void sendSonarWave(Vector2 positionOnScreen, Quaternion rot) {
		var b = Instantiate(projectile, new Vector3(positionOnScreen.x, positionOnScreen.y, 0), rot);
		b.GetComponent<Rigidbody> ().velocity = b.transform.forward * 3;
		Debug.Log (b.transform.rotation);
	}

	float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
			return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
