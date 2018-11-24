using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour {

	private GameObject warpTarget;
	public bool scoreplus { get; set; }

	// Use this for initialization
	void Start () {
		warpTarget = GameObject.Find("WarpStart");
		scoreplus = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && scoreplus == false)
		{
			scoreplus = true;
			other.gameObject.transform.position = warpTarget.transform.position;
		}
	}

}
