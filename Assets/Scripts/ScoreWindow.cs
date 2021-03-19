using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
  private Text scoreText;
  private Text highscoreText;

  private void Awake() {
    scoreText = transform.Find("scoreText").GetComponent<Text>();
    highscoreText = transform.Find("highscoreText").GetComponent<Text>();
  }
  private void Start(){
    highscoreText.text= Score.GetHighscore().ToString();
  }

  private void Update() {
   // scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
    scoreText.text = Bird.GetInstance().GetCoinsCollected().ToString();
  }
}
