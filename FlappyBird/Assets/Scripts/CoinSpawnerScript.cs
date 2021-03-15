using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour {

	// Reference to game object to spawn
	public GameObject coin;

	// Coins cpawn position to be calculated randomly
	Vector2 coinSpawnPos;

	// Use this for initialization
	void Start () {
		// Invoke Spawn coin method in 2 seconds and every 2 seconds
		InvokeRepeating ("SpawnCoin", 2f, 2f);
	}

	void SpawnCoin()
	{
		// Calculating coin Y random value
		// It's picked from -2.5, 0 and 2.5
		int randVal = (int)Random.Range (0f, 2f);
		switch (randVal) {
		case 0:
			coinSpawnPos = new Vector2 (transform.position.x, 0f);
			break;
		case 1:
			coinSpawnPos = new Vector2 (transform.position.x, -2.5f);
			break;
		case 2:
			coinSpawnPos = new Vector2 (transform.position.x, 2.5f);
			break;
		}

		// Instantiate coin in calculated spawn position
		Instantiate (coin, coinSpawnPos, Quaternion.identity);
	}

}
