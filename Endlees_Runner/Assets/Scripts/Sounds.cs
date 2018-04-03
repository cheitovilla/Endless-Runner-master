using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

	public AudioSource Mus;
	public AudioClip MusicBackground;
	// Use this for initialization
	void Start () {
		Mus.GetComponent<AudioSource> ();
		Mus.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
