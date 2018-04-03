using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {
	public Text countTextDiamonds;
	private int count;

	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Diamantes")) {
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
