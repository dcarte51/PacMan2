﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BlinkyPathing : MonoBehaviour {
    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<NavMeshAgent>().destination = target.position;

    }
}
