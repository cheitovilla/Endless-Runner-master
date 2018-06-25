using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {

	public GameObject player;
	public GameObject PanelWin;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = PanelWin.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z >= 940) {
			anim.SetTrigger("showwin");
		}
		
	}
		
}
