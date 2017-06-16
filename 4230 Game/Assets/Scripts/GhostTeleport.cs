using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTeleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private Vector3 teleport1 = new Vector3(-28f, .5f, -3f);
    private Vector3 teleport2 = new Vector3(28f, .5f, -3f);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport1"))
        {
            transform.position = teleport2;
        }
        if (other.gameObject.CompareTag("Teleport2"))
        {
            transform.position = teleport1;
        }
    }
}
