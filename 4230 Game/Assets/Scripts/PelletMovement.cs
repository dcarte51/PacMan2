using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletMovement : MonoBehaviour {

	public float amplitudeDiv;
	public float timeDiv;
	private Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {

		transform.position = startPosition + new Vector3 (0.0f, (Mathf.Sin ((Time.time)/timeDiv))/amplitudeDiv, 0.0f);

	}
}
