using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	private AudioSource dec;

	// Use this for initialization
	void Start () {
		dec = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			dec.Play();
			SceneManager.LoadScene("Main");
		}
	}

}
