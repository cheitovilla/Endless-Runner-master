using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public GameObject panel_pause;


	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Pausa(){
		panel_pause.SetActive (true);

		Time.timeScale = 0;

	}

	public void Reanudar(){
		
		panel_pause.SetActive (false);
		Time.timeScale = 1;

	}

	public void VolverInicio(){
		SceneManager.LoadScene ("Menu");
	}
}
