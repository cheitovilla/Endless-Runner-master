using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimVFX : MonoBehaviour {
	Animator anim;
	public Transform target;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.X)) {
			anim.SetTrigger ("jump");
			gameObject.transform.position = new Vector3 (target.position.x, 0.7f, target.position.z + 1f);
			//gameObject.transform.position = new Vector3 (0.022f, 0f, gameObject.transform.position.z);
		} 

		if (Input.GetKeyDown(KeyCode.C)) {
			anim.SetTrigger ("slide");
			gameObject.transform.position = new Vector3 (target.position.x, 0f, target.position.z + 2f);
			//gameObject.transform.position = new Vector3 (0.022f, 0f, gameObject.transform.position.z);
		} 

		if (target.transform.position.z >= 940) {
			anim.SetTrigger ("victory");
			gameObject.transform.position = new Vector3 (target.position.x, 1.5f, target.transform.position.z);
		}
			
	}

	public void Jumping(){
		anim.SetTrigger ("jump");
		gameObject.transform.position = new Vector3 (target.position.x, 0.7f, target.position.z + 1f);
	}

	public void Sliding(){
		anim.SetTrigger ("slide");
		gameObject.transform.position = new Vector3 (target.position.x, 0f, target.position.z + 2f);
	}
}
