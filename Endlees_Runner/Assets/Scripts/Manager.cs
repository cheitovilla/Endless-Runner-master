using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	public GameObject[] tilePrefab;

	private Transform playerTransform;
	private float spawnZ = -3.0f;
	private float tileLeght = 75.0f; // tamano de mapa 24
	private float safeZone = 70.0f; //zona segura 15
	private int amTileOnScreen = 3; // cantidad de mapas 7
	private int lastPrefabIndex = 0;

	private List<GameObject> activeTiles;


	// Use this for initialization
	void Start () {
		activeTiles = new List<GameObject> ();
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		for (int i = 0; i < amTileOnScreen; i++) {
			if (i < 2)
				SpawnTile (0);
			else
				SpawnTile ();	
		}


	}
	
	// Update is called once per frame
	void Update () {
		if (playerTransform.position.z - safeZone> (spawnZ- amTileOnScreen * tileLeght)) {
			SpawnTile ();
			DeleteTile ();
		}
		
	}

	private void SpawnTile (int prefabIndex = -1){


		GameObject go;

		if (prefabIndex == -1)
			go = Instantiate (tilePrefab [RandomPrefabIndex ()]) as GameObject;
		else
			go = Instantiate (tilePrefab [prefabIndex]) as GameObject;
		
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLeght;
		activeTiles.Add (go);
	}

	private void DeleteTile(){
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex(){
		if (tilePrefab.Length <=1) 
			return 0;

			int randomIndex = lastPrefabIndex;
			while (randomIndex == lastPrefabIndex) 
			{
				randomIndex = Random.Range (0, tilePrefab.Length);
			}
			lastPrefabIndex = randomIndex;
			return randomIndex;
		}

}
