using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        var speed = 1.0f;
        Vector3 position = this.transform.position;

        var x = 0f;
        var y = 0f;

        if (Input.GetKey(KeyCode.W)) {
            y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            x += speed * Time.deltaTime;
        }
 
        position.x += x;
        position.y += y;

        this.transform.position = position;
    }
}
