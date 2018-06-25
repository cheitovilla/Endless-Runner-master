using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PruebaPlayer : MonoBehaviour {
	
	public float moveSpeed = 5.0f;
	public float JumpForce;
	private Rigidbody rb;
	public Audio audio;
	Animator anim;

	public bool enSuelo = true;
	private bool isDead = false;
	//PruebaPlayer powerUps;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		audio.AudioFondo ();
	}

	public void Saltarr(){
		if (enSuelo) {
			enSuelo = false;
			anim.SetTrigger ("jump");
			rb.velocity = new Vector3 (rb.velocity.x, JumpForce, moveSpeed);
			audio.SonarSalto ();
		}
	}

	public void Slidee(){
		anim.SetTrigger ("slide");
		audio.SonarDeslizar ();

	}

	// Update is called once per frame
	void Update () {

		if (isDead)
			return;
		

		
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, moveSpeed);

		//Saltarr ();
		//Slidee ();

		if (Input.GetKeyDown(KeyCode.X)) {
			if (enSuelo) {
				enSuelo = false;
				anim.SetTrigger ("jump");
				rb.velocity = new Vector3 (rb.velocity.x, JumpForce, moveSpeed);
				audio.SonarSalto ();
			}
		} 


		if (Input.GetKeyDown(KeyCode.C)) {
			anim.SetTrigger ("slide");
			audio.SonarDeslizar ();
		}

		if (rb.transform.position.z>=940) {
			anim.SetTrigger ("victory");
			rb.velocity = new Vector3 (0, 0, 0);
			//audio.SonarGanar ();
		}

	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Obstaculo") {
			//Death();
			if (FindObjectOfType<PowerUps> ().shield == true) {
				Destroy (collision.gameObject);
				FindObjectOfType<PowerUps> ().powerUp_shield.SetActive (false);
			}

			if(FindObjectOfType<PowerUps>().shield == false) {
				Death ();
			}
				
		
		}




		if (collision.gameObject.tag == "Piso") {
			enSuelo = true;
		}
		
	}

	private void Death() {
		isDead = true;
		Debug.Log ("dead");
		anim.SetTrigger ("dead");
		GetComponent<Score> ().onDeath ();
	}
	 	
	public void SetSpeed(float modifer){
		moveSpeed = 5.0f + modifer;
	}


}
