﻿using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D target) {
		if (target.gameObject.tag == "trigger-1") {
			Debug.Log("trigger 1 activated");
		}
	}
}
