using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score 
{

    public static void Start(){
      //  ResetHighScore();
        Bird.GetInstance().OnDied+=Bird_OnDied;

    }
    private static void Bird_OnDied(object sender, System.EventArgs e){
        TrySetNewHighScore(Bird.GetInstance().GetCoinsCollected());


    }
  public static int GetHighscore(){
      return PlayerPrefs.GetInt("highscore");
  }
  public static bool TrySetNewHighScore(int score){
      int currentHighScore=GetHighscore();
      if(score>currentHighScore){
          //high score
           PlayerPrefs.SetInt("highscore",score);
        PlayerPrefs.Save();
        return true;
      }
      else{
          return false;
      }
  }
  public static void ResetHighScore(){
         PlayerPrefs.SetInt("highscore",0);
        PlayerPrefs.Save();

  }
}
