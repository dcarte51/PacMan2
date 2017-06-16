using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class ClydePathing : MonoBehaviour
{

    private Vector3 location = new Vector3(0f, 0f, 0f);
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == location)
        {
            float xPos = Random.Range(-24.75f, 31f);
            float zPos = Random.Range(-28f, 39f);

            Vector3 location = new Vector3(xPos, 0f, zPos);
        }


        transform.GetComponent<NavMeshAgent>().destination = location;

    }

}
