using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	private float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		speed = 10.0f;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		rb.velocity = z * transform.forward * speed + x * transform.right * speed;

	}

}
