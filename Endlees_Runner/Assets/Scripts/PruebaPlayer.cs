using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PruebaPlayer : MonoBehaviour {
	
	public float moveSpeed = 5.0f;
	public float JumpForce;
	private Rigidbody rb;
	public Audio audio;
	Animator anim;

	private bool isDead = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();



	}

	// Update is called once per frame
	void Update () {

		if (isDead)
			return;
		

		
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, moveSpeed);

		if (Input.GetKeyDown(KeyCode.X)) {
			anim.SetTrigger ("jump");
			rb.velocity = new Vector3 (rb.velocity.x, JumpForce, moveSpeed);
			audio.SonarSalto ();
		} 

		if (Input.GetKeyDown(KeyCode.C)) {
			anim.SetTrigger ("slide");
			audio.SonarDeslizar ();
		}
		
	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Obstaculo") {
			Death ();
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
