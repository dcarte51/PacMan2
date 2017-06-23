using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class ClydePathing : MonoBehaviour
{
    PauseScript canvas;

    private Vector3 teleport1 = new Vector3(-30f, .5f, -3f);
    private Vector3 teleport2 = new Vector3(30f, .5f, -3f);
    private Vector3 teleLocation1 = new Vector3(-27f, -1f, 8f);
    private Vector3 teleLocation2 = new Vector3(27f, -1f, 8f);

    private Vector3[] locations = new Vector3[15];
    private Vector3 destination = new Vector3(0f,0f,0f);
    

    // Use this for initialization
    void Start()
    {
        locations[0] = new Vector3(0f, 0f, 33f);
        locations[1] = new Vector3(-26.8f, 0f, 33f);
        locations[2] = new Vector3(28.5f, 0f, 33f);
        locations[3] = new Vector3(28.5f, 0f, 11f);
        locations[4] = new Vector3(-26.8f, 0f, 11f);
        locations[5] = new Vector3(.5f, 0f, 18f);
        locations[6] = new Vector3(17.3f, 0f, -3.5f);
        locations[7] = new Vector3(-16f, 0f, -3.5f);
        locations[8] = new Vector3(-26.8f, 0f, -18.3f);
        locations[9] = new Vector3(28.5f, 0f, -18.3f);
        locations[10] = new Vector3(28.5f, 0f, -35f);
        locations[11] = new Vector3(-26.8f, 0f, -35f);
        locations[12] = new Vector3(.75f, 0f, -25f);

        int rand = Random.Range(0, 13);
       destination = locations[rand];
       transform.GetComponent<NavMeshAgent>().destination = destination;
    }


    // Update is called once per frame
    void Update()
    {

        var distanceToTele1 = Vector3.Distance(transform.position, teleport1);
        var distanceToTele2 = Vector3.Distance(transform.position, teleport2);
        var destToTele1 = Vector3.Distance(destination, teleport1);
        var destToTele2 = Vector3.Distance(destination, teleport2);
        var distToDest = Vector3.Distance(transform.position, destination);

        if (transform.position.x == destination.x && transform.position.z == destination.z)
        {
            int rand = Random.Range(0, 13);
            destination = locations[rand];

            if ((distanceToTele1 + destToTele2) < distToDest)
            {
                transform.GetComponent<NavMeshAgent>().destination = teleport1;
            }
            else if ((distanceToTele2 + destToTele1) < distToDest)
            {
                transform.GetComponent<NavMeshAgent>().destination = teleport2;
            }
            else
            {
                transform.GetComponent<NavMeshAgent>().destination = destination;
            }
        }
       /* if (transform.position.x == destination.x && transform.position.z == destination.z)
        {
            int rand = Random.Range(0, 13);
            destination = locations[rand];
            transform.GetComponent<NavMeshAgent>().destination = destination;
        }*/


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
