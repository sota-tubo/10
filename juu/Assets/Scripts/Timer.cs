using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private Text timeText;
	public float timesec { get; set; }

	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text>();
		timesec = 11.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (timesec < 1f)
		{
			timesec = 0f;
			SceneManager.LoadScene("GameOver");
		}
	}

	private void FixedUpdate()
	{
		//端から端まで辿り着くのに3秒ほどかかるので最終リミットは4秒から
		timesec -= Time.deltaTime / 3;

		timeText.text = ((int)timesec).ToString();
	}

}
