using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private float score = 0.0f;
	public Text scoreText;
	private int difficultyLevell = 1;
	private int maxDifficultyLevel = 10;
	private int scoreToNextLevel=10;

	private bool isDead = false;
	public DeadMenu deadMenu;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//score += Time.deltaTime;
		if (isDead)
			return;


		if (score >= scoreToNextLevel) 
			LevelUp ();
		
			score += Time.deltaTime * difficultyLevell;
			scoreText.text = ((int)score).ToString () + " m";

		if (score >=500) {
			score = 500;
		}
	}



	void LevelUp() {
		if (difficultyLevell == maxDifficultyLevel) 
			return;
		
		scoreToNextLevel *= 2;
		difficultyLevell++;
		GetComponent<PruebaPlayer> ().SetSpeed (difficultyLevell);
		Debug.Log (difficultyLevell);
	}


	public void onDeath(){
		isDead = true;
		deadMenu.ToggleEndMenu (score);
	}

}
