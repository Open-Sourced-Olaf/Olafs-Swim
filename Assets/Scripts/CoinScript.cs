using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

  // Coins move speed can be set in Inspector
  public float moveSpeed = -5f;

  // If coin collides with Cat
  void OnTriggerEnter2D (Collider2D col) {
    if (col.gameObject.tag.Equals("Player")) {

      // then picked coins number is increased by one
      CoinCounterScript.numberOfCoins += 1;

      // and coin is destroyed
      Destroy(gameObject);
    }
  }

  void Start() {

    // if coin is not picked then it will be destroyed in 9 seconds
    Destroy(gameObject, 9f);
  }

  void Update() {
    // move coin according to move speed
    transform.position = new Vector2 (transform.position.x + moveSpeed * Time.deltaTime,
                                      transform.position.y);
  }
}
