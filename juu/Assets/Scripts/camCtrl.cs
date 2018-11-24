using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camCtrl : MonoBehaviour {

	private float rotSpeed;
	private Transform camPos;

	// Use this for initialization
	void Start () {
		rotSpeed = 5.0f;
		camPos = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		float rot = Input.GetAxis("Mouse X");
		if (Input.GetMouseButton(1))
		{
			camPos.Rotate(0, rot * rotSpeed, 0);
		}
	}
}
