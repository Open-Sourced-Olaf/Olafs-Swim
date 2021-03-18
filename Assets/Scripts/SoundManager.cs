﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public  static class SoundManager
{


    public enum Sound{
        BirdJump,
        Score,
        Lose,
        ButtonOver,
        ButtonClick,

    }
    //pass Sound sound in arguments
  public static void PlaySound(){
      GameObject gameObject=new GameObject("Sound",typeof(AudioSource));
      AudioSource audioSource =gameObject.GetComponent<AudioSource>();
      audioSource.PlayOneShot(GameAssets.GetInstance().birdJump);
    //   audioSource.PlayOneShot(GetAudioClip(sound));
  }

  /*private static AudioClip GetAudioClip(Sound sound){
      foreach(GameAssets.SoundAudioClip soundAudioClip in GameAssets.GetInstance().soundAudioClipArray){
          if(soundAudioClip.sound==sound){
              return soundAudioClip.audioClip;
          }
      }
      Debug.LogError("Sound"+sound+"not found");
      return null;
  }
  public static void AddButtonSounds(this Button_UI buttonUI){
      buttonUI.MouseOverOnceFunc+=()=>PlaySound(Sound.ButtonOver);
      buttonUI.ClickFunc+=()=>PlaySound(Sound.ButtonClick);

  }*/

}
