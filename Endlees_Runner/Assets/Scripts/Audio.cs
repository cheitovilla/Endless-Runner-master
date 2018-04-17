using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour 
{
	public Transform spawnpoint;
	public AudioSource source;
	public AudioClip efectoMenu;
	public AudioClip efectoDiamante;
	//public AudioClip efectoChoque;
	

//aquí estan todos los audios asignados
	void Start ()
	{
		{
			source = spawnpoint.GetComponent<AudioSource> ();
		}
	}

	private void Update ()
	{
		
	}

	public void SonarDiamante ()
	{
		source.PlayOneShot (efectoDiamante);
	}
		public void SonarMenu ()
	{
		source.PlayOneShot (efectoMenu);
	}
	/*	public void SonarChoque ()
	{
		source.PlayOneShot (efectoChoque);
	} */
}
