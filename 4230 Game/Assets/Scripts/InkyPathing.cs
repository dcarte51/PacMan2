using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class InkyPathing : MonoBehaviour
{
    private GameObject player;
    private GameObject target;
    private Vector3 destination;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        target = GameObject.FindGameObjectWithTag("InkyTarget");
        player = GameObject.FindGameObjectWithTag("Player");

        var distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);

        if (distToPlayer <= 12)
        {
            destination = player.transform.position;
        }
        else
        {
            destination = target.transform.position;
        }

        transform.GetComponent<NavMeshAgent>().destination = destination;

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