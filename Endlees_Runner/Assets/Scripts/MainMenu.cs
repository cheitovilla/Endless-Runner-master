﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public Audio audiomenu;

	public void PlayGame(){
		audiomenu.SonarMenu ();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void ExitAplication(){
		audiomenu.SonarMenu ();
		Application.Quit ();
	}
}
