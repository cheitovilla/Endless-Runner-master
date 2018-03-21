using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPlayer : MonoBehaviour {
	
	public float moveSpeed = 5.0f;
	public float JumpForce;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void Update () {
		
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, moveSpeed);
		if (Input.GetButtonDown ("Jump")) {
			rb.velocity = new Vector3 (rb.velocity.x, JumpForce, moveSpeed);

		} 
		
	}

	public void SetSpeed(float modifer){
		moveSpeed = 5.0f + modifer;
	}

}
