using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BlinkyPathing : MonoBehaviour {
    public Transform target;
    PauseScript canvas;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<NavMeshAgent>().destination = target.position;

        if (Time.timeScale == 0)
        {
            transform.GetComponent<NavMeshAgent>().speed = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            transform.GetComponent<NavMeshAgent>().speed = 4f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
            

    }
}
