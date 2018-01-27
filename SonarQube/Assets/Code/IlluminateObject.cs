﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IlluminateObject : MonoBehaviour{

    public Color colorStart = new Color(255F, 255F, 255F, 255F);
	Color fading;
    public float rate = 100.0F;
    public Material _material;
	Shader shader;

    void Start() {
        _material = this.GetComponent<Renderer>().material;
    }
    void Update() {
		if(Input.GetKey(KeyCode.Q)) {
			fading = colorStart;
		}
		fading.a -= rate * Time.deltaTime;
		_material.color = fading;
		Debug.Log(_material.color);
    }
}