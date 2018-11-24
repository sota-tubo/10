using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour {

	private GameObject warpTarget;

	// Use this for initialization
	void Start () {
		warpTarget = GameObject.Find("WarpStart");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.transform.position = warpTarget.transform.position;
		}
	}

}
