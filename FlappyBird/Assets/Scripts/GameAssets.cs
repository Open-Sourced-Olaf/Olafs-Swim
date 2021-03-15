using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======
using System;
>>>>>>> demo-branch

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;

    public static GameAssets GetInstance() {
      return instance;
    }

    private void Awake() {
      instance = this;
    }

    public Sprite pipeHeadSprite;
    public Transform pfPipeHead;
    public Transform pfPipeBody;
<<<<<<< HEAD
=======
     public Transform pfGround;
    public AudioClip birdJump;
    // public SoundAudioClip[] soundAudioClipArray;
    // [Serializable]
    // public class SoundAudioClip{
    //   public SoundManager.Sound sound;
    //   public AudioClip audioClip;
    // }
>>>>>>> demo-branch
}
