using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {
	public Text countTextDiamonds;
	private int count;
	public Audio audio;


	// Use this for initialization
	void Start () {
		//audio = GetComponent<Audio> ();
		count = 0;
		SetCountText ();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Diamantes")) {
			audio.SonarDiamante ();
			other.gameObject.SetActive (false);
			count = count + 10;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countTextDiamonds.text = "Score: " + count.ToString ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
