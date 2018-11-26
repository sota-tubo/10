using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomOut : MonoBehaviour {

	public List<GameObject> gates { get; set; }
	public int round { get; set; }

	// Use this for initialization
	void Start () {
		gates = new List<GameObject>();
		round = 1;
		randomselect();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void randomselect()
	{
		for (int i = 1; i <= round; i++)
		{
			int rand = Random.Range(1, 7);
			while(true)
			{
				string randstr = "Gate" + rand.ToString();
				GameObject randObj = GameObject.Find(randstr);
			    if (gates.Contains(randObj) == false)
				{
					gates.Add(randObj);
				    Debug.Log("add.");
					break;
				}
				else
				{
					rand = Random.Range(1, 7);
				}
			}
			Debug.Log(gates[i - 1].name);
		}

		StartCoroutine("VisOut");

	}

    //時間経過でxマーク表示
	IEnumerator VisOut()
	{

		yield return new WaitForSeconds(2.0f * 3.0f);

		Debug.Log("First");

		if (round == 5)
		{
			GameObject randgate = gates[4];
			GameObject outObj = gates[4].transform.Find("out").gameObject;
			outObj.SetActive(true);
		}

		yield return new WaitForSeconds(1.0f * 3.0f);

		Debug.Log("Second");

		if (round >= 4)
        {
            GameObject randgate = gates[3];
            GameObject outObj = gates[3].transform.Find("out").gameObject;
			outObj.SetActive(true);
        }

		yield return new WaitForSeconds(1.0f * 3.0f);

		Debug.Log("Third");

		if (round >= 3)
        {
            GameObject randgate = gates[2];
            GameObject outObj = gates[2].transform.Find("out").gameObject;
			outObj.SetActive(true);
        }
        
		yield return new WaitForSeconds(1.0f * 3.0f);

		Debug.Log("Fourth");

		if (round >= 2)
        {
            GameObject randgate = gates[1];
            GameObject outObj = gates[1].transform.Find("out").gameObject;
			outObj.SetActive(true);
        }
        
		yield return new WaitForSeconds(1.0f * 3.0f);

		Debug.Log("Last");

		if (round >= 1)
        {
            GameObject randgate = gates[0];
            GameObject outObj = gates[0].transform.Find("out").gameObject;
			outObj.SetActive(true);
        }

	}

}
