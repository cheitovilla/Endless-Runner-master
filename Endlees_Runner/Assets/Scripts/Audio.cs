using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour 
{
	public Transform spawnpoint;
	public AudioSource source;
	public AudioClip musicaFondo;
	public AudioClip efectoMenu;
	public AudioClip efectoDiamante;
	public AudioClip efectoSalto;
	public AudioClip efectoDeslizar;
//	public AudioClip efectoGanar;
	

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

	public void AudioFondo(){
		source.PlayOneShot (musicaFondo);
	}

	public void SonarDiamante ()
	{
		source.PlayOneShot (efectoDiamante);
	}

	public void SonarMenu ()
	{
		source.PlayOneShot (efectoMenu);
	}

	public void SonarSalto ()
	{
		source.PlayOneShot (efectoSalto);
	} 

	public void SonarDeslizar(){
		source.PlayOneShot (efectoDeslizar);
	}

//	public void SonarGanar(){
//		source.PlayOneShot (efectoGanar);
//
//	}

}

