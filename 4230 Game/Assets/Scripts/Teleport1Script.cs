using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1Script : MonoBehaviour {

    private Vector3 tele2 = new Vector3(28f, .5f, 3f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = tele2;
    }
}
