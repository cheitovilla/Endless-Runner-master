using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public GameObject powerUp_shield;
	public bool shield;

	// Use this for initialization
	void Start () {
		powerUp_shield.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "powerUp") {
			powerUp_shield.SetActive (true);
			shield = true;
		}
	}


}
