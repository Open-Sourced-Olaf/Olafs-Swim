using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterScript : MonoBehaviour {

	// Variable to contain number of picked coins
	// accessable from another scripts
	public static int numberOfCoins;

	// Reference to coin counter text game object
	Text coinCounterText;
	  private static CoinCounterScript instance;

    public static CoinCounterScript GetInstance() {
      return instance;
    }

	// Use this for initialization
	void Start () {

		// Number of coins is 0 initially
		numberOfCoins = 0;

		// Getting text component of coin counter text game object
		coinCounterText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		// Setting text with coins number every frame
		coinCounterText.text = "Coin: " + numberOfCoins.ToString ();
	}
}
