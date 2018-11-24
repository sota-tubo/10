using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int score;
	private float timeScore;
	[SerializeField]
	private Timer timer;
	[SerializeField]
	private WarpPoint warpPoint;

	// Use this for initialization
	void Start () {
		score = 0;
		timeScore = -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (warpPoint.scoreplus == true)
		{
			warpPoint.scoreplus = false;
			timeScore = timer.timesec;
			plus(timeScore);
		}
	}

    void plus(float time)
	{
		//スコアの配分
	}

}
