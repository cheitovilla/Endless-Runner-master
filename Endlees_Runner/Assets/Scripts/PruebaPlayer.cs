using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PruebaPlayer : MonoBehaviour {
	
	public float moveSpeed = 5.0f;
	public float JumpForce;
	private Rigidbody rb;
	public Audio audio;

	Animator anim;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {
		
		
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, moveSpeed);

		if (Input.GetKeyDown(KeyCode.X)) {
			audio.SonarSalto ();
			rb.velocity = new Vector3 (rb.velocity.x, JumpForce, moveSpeed);
			anim.SetTrigger ("jump");
		
		} 
		if (Input.GetKey(KeyCode.C)) {
			anim.SetTrigger ("slide");
		}
		
	}
	 	


	public void SetSpeed(float modifer){
		moveSpeed = 5.0f + modifer;
	}

	
}
