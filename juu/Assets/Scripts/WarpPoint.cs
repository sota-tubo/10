using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpPoint : MonoBehaviour {

	[SerializeField]
	private Timer timer;
	[SerializeField]
	private Score score;

	private randomOut rndOut;
	private GameObject warpTarget;

	// Use this for initialization
	void Start () {
		rndOut = GameObject.Find("GameSystem").GetComponent<randomOut>();
		warpTarget = GameObject.Find("WarpStart");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			//当たりの扉に入った場合
			if (rndOut.gates.Contains(transform.root.gameObject) == false)
			{
				//スコア計算
				score.plus(timer.timesec);
				
                //ラウンド5の時
				if (rndOut.round == 5)
				{
					SceneManager.LoadScene("GameClear");
				}

				//xマークを消す
				for (int i = 0; i < rndOut.round; i++)
				{
					GameObject randgate = rndOut.gates[i];
					GameObject outObj = randgate.transform.Find("out").gameObject;
					outObj.SetActive(false);
				}
                
                other.gameObject.transform.position = warpTarget.transform.position;
				//ハズレの扉の配置を変更
                rndOut.gates.Clear();
				rndOut.round++;
                rndOut.randomselect();
				timer.timesec = 11f;
			}
			//ハズレの扉に入った場合
			else if (rndOut.gates.Contains(transform.root.gameObject) == true)
			{
				SceneManager.LoadScene("GameOver");
			}
		}
	}

}
