using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public float score = 0.0f;
	public Text scoreText;
	private int difficultyLevell = 1;
	private int maxDifficultyLevel = 10;
	private int scoreToNextLevel=10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//score += Time.deltaTime;
		 if (score >= scoreToNextLevel) 
			LevelUp ();
		
			score += Time.deltaTime * difficultyLevell;
			scoreText.text = ((int)score).ToString ();
		
	}

	void LevelUp() {
		if (difficultyLevell == maxDifficultyLevel) 
			return;
		
		scoreToNextLevel *= 2;
		difficultyLevell++;
		GetComponent<PruebaPlayer> ().SetSpeed (difficultyLevell);
		Debug.Log (difficultyLevell);
	}
}
