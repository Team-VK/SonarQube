using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSonar : MonoBehaviour {

	Light sonar;

	void Start() {
		sonar = GameObject.Find("Sonar").GetComponent<Light>();
	}
	
	void Update() {
		Vector2 positionOnScreen = sonar.transform.position;
		Vector2 mouseOnScreen = (Vector2)Input.mousePosition;
		float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
		if(angle > 55) {
			angle = 55;
		}
		else if(angle < -55) {
			angle = -55;
		}
			
		Quaternion rotation = Quaternion.Euler (new Vector3 (angle, 90, 0f));
		sonar.transform.rotation = rotation;

		if (Input.GetKeyDown ("space")) {
			sendSonarWave(positionOnScreen, mouseOnScreen, rotation);
		}
	}

	//Sends a sonar wave in the direction pointed by the sonar device
	void sendSonarWave(Vector2 positionOnScreen, Vector2 mouseOnScreen, Quaternion rotation) {
		GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.position = new Vector3 (positionOnScreen.x, positionOnScreen.y, 0);
		cylinder.transform.localScale = new Vector3(1, 1, 1);
		cylinder.transform.rotation = rotation;
	}

	float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
			return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
