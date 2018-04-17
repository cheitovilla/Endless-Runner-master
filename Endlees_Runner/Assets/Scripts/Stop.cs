using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour 
{
	public bool pause;
	void Start () 
	{
		pause = false;
	}
	//Pausa
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.P)) 
		{
			if (pause == true) 
		    { 	
				pause = false;
					print("Ya no estoy pausado");
			} 
			else 
			{
			
				pause = true;
				print("Estoy pausado");
			}
		}
	}
}
