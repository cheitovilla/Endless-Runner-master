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
			gameObject.transform.position = new Vector3 (target.position.x, 0.7f, target.position.z);
			//gameObject.transform.position = new Vector3 (0.022f, 0f, gameObject.transform.position.z);
		} 


	}
}
