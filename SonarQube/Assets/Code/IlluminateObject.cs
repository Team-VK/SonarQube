using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IlluminateObject : MonoBehaviour{

    public float colorStart = 1.0f;
	float fading;
    public float rate = 0.5f;
    Renderer rend;
    Color color;

    void Start() {
        rend = this.GetComponent<Renderer>();
    }
    void Update() {
		if(Input.GetKey(KeyCode.Q)) {
			fading = colorStart;
		}
        fading -= rate * Time.deltaTime;
        color = rend.material.color;
        color.a = fading;
		rend.material.color = color;
		//Debug.Log(_material.color);
    }
	
	void OnTriggerEnter(Collider col)
    {
		fading = colorStart;
	}
}
