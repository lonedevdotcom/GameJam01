﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float rotationSpeed = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * rotationSpeed);
	}
}
