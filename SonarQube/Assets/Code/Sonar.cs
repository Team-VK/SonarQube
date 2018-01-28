using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour {

	public Transform projectile;
	GameObject sonar;
	GameObject crosshair;
	public Transform pushingprojectile;

	void Start() {
		sonar = GameObject.FindWithTag("Sonar");
		crosshair = GameObject.FindWithTag("Crosshair");

	}

	void Update() {
		Vector3 positionOnScreen = sonar.transform.position;
		//print (crosshair.normal);	
		Vector3 crosshairPosition = crosshair.transform.position;
		//Debug.DrawLine (sonar.transform.position, crosshair.transform.position, Color.red, 10f, false);
		float angle = AngleBetweenTwoPoints(positionOnScreen, crosshairPosition);

		Vector3 trajectory =  crosshairPosition - positionOnScreen;
		trajectory.z = 0f;
		//Debug.Log (trajectory);
		trajectory = trajectory.normalized;

		if(angle > 65) {
			angle = 65;
		}
		else if(angle < -65) {
			angle = -65;
		}

		Quaternion rot = Quaternion.Euler (new Vector3 (8f*angle, 90, 0f));
		sonar.transform.rotation = rot;
		//crosshair.transform.rotation = rot;

		if (Input.GetKeyDown(KeyCode.Space)) {
			sendSonarWave(positionOnScreen, rot, trajectory);
			//Debug.Log (rot);
		}
		if (Input.GetKeyDown(KeyCode.C)) {
			sendPushWave(positionOnScreen, rot, trajectory);
			//Debug.Log (rot);
		}
	}

	//Sends a sonar wave in the direction pointed by the sonar device
	void sendSonarWave(Vector2 positionOnScreen, Quaternion rot, Vector3 trajectory) {
		var b = Instantiate(projectile, new Vector3((positionOnScreen.x*1.05f), (positionOnScreen.y), 0), rot);
		b.GetComponent<Rigidbody> ().velocity = trajectory * 20;
		//Debug.Log (b.transform.rotation);
	}

	//Send a pushing wave
	void sendPushWave(Vector2 positionOnScreen, Quaternion rot, Vector3 trajectory) {
		var b = Instantiate(pushingprojectile, new Vector3((positionOnScreen.x * 1.05f), (positionOnScreen.y), 0), rot);
		b.GetComponent<Rigidbody> ().velocity = trajectory * 20;
	}

	float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
			return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
