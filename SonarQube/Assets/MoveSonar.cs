using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSonar : MonoBehaviour {

	Light sonar;

	// Use this for initialization
	void Start() {
		sonar = GameObject.Find("Sonar").GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update() {
		Vector2 positionOnScreen = sonar.transform.position;
		Vector2 mouseOnScreen = (Vector2)Input.mousePosition;
		float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
		sonar.transform.rotation =  Quaternion.Euler(new Vector3(angle,90,0f));
	}

	float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
			return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
