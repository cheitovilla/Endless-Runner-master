using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveVector; 
	public float speed = 3f;
	private float verticalVelocity = 0f;
	private float gravity = 12f;
	private float animationDuration = 3.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time < animationDuration) {
			controller.Move (Vector3.forward * speed * Time.deltaTime);
			return;
		}

		moveVector = Vector3.zero;

		if (controller.isGrounded) 
		{
			verticalVelocity = -0.5f;
		} 
		else 
		{
			verticalVelocity -= gravity * Time.deltaTime;
		}

		//X left - right
	//	moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

		//Y down - up
		if (Input.GetButtonDown ("Jump") && controller.isGrounded) {
			moveVector.y = 4 * speed;
		}
		else 
		{
			moveVector.y = verticalVelocity;

		}

		//Z Forward - front
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);
	}
}
