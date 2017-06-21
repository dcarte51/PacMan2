using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BlinkyPathing : MonoBehaviour {
    public Transform target;
    PauseScript canvas;

    private Vector3 teleport1 = new Vector3(-30f, .5f, -3f);
    private Vector3 teleport2 = new Vector3(30f, .5f, -3f);
    private Vector3 teleLocation1 = new Vector3(-28f, -1f, 8f);
    private Vector3 teleLocation2 = new Vector3(28f, -1f, 8f);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var distanceToTele1 = Vector3.Distance(transform.position, teleport1);
        var distanceToTele2 = Vector3.Distance(transform.position, teleport2);
        var objectToTele1 = Vector3.Distance(target.position, teleport1);
        var objectToTele2 = Vector3.Distance(target.position, teleport2);
        var distToObject = Vector3.Distance(transform.position, target.position);

        if ((distanceToTele1 + objectToTele2) < distToObject)
        {
            transform.GetComponent<NavMeshAgent>().destination = teleport1;
        }
        else if ((distanceToTele2 + objectToTele1) < distToObject)
        {
            transform.GetComponent<NavMeshAgent>().destination = teleport2;
        }
        else
        {
            transform.GetComponent<NavMeshAgent>().destination = target.position;
        }

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport1"))
        {
            transform.position = teleLocation2;
        }
        if (other.CompareTag("Teleport2"))
        {
            transform.position = teleLocation1;
        }
    }
}
