using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    
    private float roof = 5f;
    private float floor = -4f;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        var playerspeed = 3.0f;
		var crosshairspeed = 3.0f;
        Vector3 position = this.transform.position; //Can represent either the player or the crosshair

        var x = 0f;
        var y = 0f;

        if (Input.GetKey(KeyCode.W)) {
			y += playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
			y -= playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
			x -= playerspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
			x += playerspeed * Time.deltaTime;
        }

		//Crosshair controls
		if (this.CompareTag ("Crosshair") == true) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				y += crosshairspeed * Time.deltaTime;
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				y -= crosshairspeed * Time.deltaTime;
			}
		}
 
        position.x += x;
        position.y += y;
		position.z = 0f;

        // Prevent player moving beyond the roof and floor values
        if (position.y > roof) {
            position.y = roof;
        }
        else if (position.y < floor) {
            position.y = floor;
        }

		Debug.Log ("Position x,y,z: " + position.x + ", " + position.y + ", " + position.z);

        this.transform.position = position;
    }
}
