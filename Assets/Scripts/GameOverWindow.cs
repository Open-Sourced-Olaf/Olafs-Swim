using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using CodeMonkey;

public class GameOverWindow : MonoBehaviour
{
   private Text scoreText;
   private void Awake(){
       scoreText=transform.Find("scoreText").GetComponent<Text>();
       transform.Find("retryBtn").GetComponent<Button_UI>().ClickFunc=()=>{
Loader.Load(Loader.Scene.GameScene);
        ///    UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene"); 
            };
         //  transform.Find("retryBtn").GetComponent<Button_UI>().AddButtonSounds();
             transform.Find("menuBtn").GetComponent<Button_UI>().ClickFunc=()=>{
Loader.Load(Loader.Scene.MainMenu);
        ///    UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene"); 
            };
              //   transform.Find("menuBtn").GetComponent<Button_UI>().AddButtonSounds();
       
   }
   private void Start(){
       
       Bird.GetInstance().OnDied+=Bird_OnDied;
        Hide();

   }
   private void Bird_OnDied(object sender, System.EventArgs e){
     
       
    scoreText.text=Level.GetInstance().GetPipesPassedCount().ToString();
     Show();
        CMDebug.TextPopupMouse("Dead!");
   
   }

   private void Show(){
     gameObject.SetActive(true);
   }

   private void Hide(){
       gameObject.SetActive(false);
   }
}
