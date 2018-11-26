using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		
	}

	public void plus(float time)
	{
		//スコアの配分
		if (time >= 8f)
		{
			score += 10;
		}
		else if ( time < 8f && time >= 7f)
		{
			score += 8;
		}
		else if ( time < 7f && time >= 6f)
		{
			score += 5;
		}
		else if (time < 6f && time >= 5f)
		{
			score += 3;
		}
		else if (time < 5f && time >= 4f)
		{
			score += 1;
		}
	}

}
