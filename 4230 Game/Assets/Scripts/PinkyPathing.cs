﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyPathing : MonoBehaviour {
    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.forward.normalized + new Vector3(0f, 0f, 5f);
	}
}
