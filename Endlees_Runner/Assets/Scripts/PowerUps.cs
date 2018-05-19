using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	public GameObject powerUp_shield;
	public bool shield;
	public float timeShield;
	public bool x2;
	public float timex2 = 0f;

	// Use this for initialization
	void Start () {
		powerUp_shield.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Buclex2 ();
		BucleShield ();

	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "powerUpShield") {
			//powerUp_shield.SetActive (true);
			shield = true;
			Destroy (other.gameObject);
			//if (FindObjectOfType<PruebaPlayer> ())
			//	FindObjectOfType<PruebaPlayer> ().shieldActive = true;
		} 

		if (other.tag == "powerUpx2") {
			x2 = true;
			Destroy (other.gameObject);
		}
			
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Obstaculo") {
			shield = false;
			timeShield = 0;
		}
	}

	void Buclex2(){
		if (x2 == true) {
			timex2 += Time.deltaTime;
			if (timex2>= 7) {
				timex2 = 0;
				x2 = false;
			}
		}
	}

	void BucleShield(){
		if (shield == true) {
			powerUp_shield.SetActive (true);
			timeShield += Time.deltaTime;
			if (timeShield >= 10) {
				powerUp_shield.SetActive (false);
				timeShield = 0;
				shield = false;
			}
		}
	}

}
