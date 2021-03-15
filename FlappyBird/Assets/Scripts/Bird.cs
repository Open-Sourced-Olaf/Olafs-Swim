<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using System;
>>>>>>> demo-branch

public class Bird : MonoBehaviour
{
    private const float JUMP_AMOUNT = 100f;
<<<<<<< HEAD

    private static Bird instance;

    public static Bird GetInstance() {
      return instance;
    }

    public event EventHandler OnDied;
    public event EventHandler OnStartedPlaying;

    private Rigidbody2D birdRigidbody2D;
    private State state;

    private enum State {
      WaitingToStart,
      Playing,
      Dead
    }

    private void Awake() {
      instance = this;
      birdRigidbody2D = GetComponent<Rigidbody2D>();
      birdRigidbody2D.bodyType = RigidbodyType2D.Static;
      state = State.WaitingToStart;
    }

    private void Update() {
      switch (state) {
        default:
        case State.WaitingToStart:
          if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            state = State.Playing;
            birdRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
            Jump();
            if (OnStartedPlaying != null) OnStartedPlaying(this, EventArgs.Empty);
          }
          break;
        case State.Playing:
          if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            Jump();
          }
          break;
        case State.Dead:
          break;
      }

=======
    private static Bird instance;
    public static Bird GetInstance(){
      return instance;
    }
    public event EventHandler OnDied;
      public event EventHandler OnStartedPlaying;

    private State state;

    private Rigidbody2D birdRigidbody2D;
private enum State{
  WaitingToStart,
  Playing,
  Dead
}
    private void Awake() {
      instance=this;
      
      birdRigidbody2D = GetComponent<Rigidbody2D>();
      birdRigidbody2D.bodyType=RigidbodyType2D.Static;
      state=State.WaitingToStart;
    }

    private void Update() {
      switch(state){
        default:
        case State.WaitingToStart:{
          if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
          state=State.Playing;
          birdRigidbody2D.bodyType=RigidbodyType2D.Dynamic;
        Jump();
        if(OnStartedPlaying!=null){
          OnStartedPlaying(this,EventArgs.Empty);
        }
      }

        }
        
        break;
        case State.Playing:{
          if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
        Jump();
      }

        }
        
        break;
        case State.Dead:
        break;
      }
      
>>>>>>> demo-branch
    }

    private void Jump() {
      birdRigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;
<<<<<<< HEAD
    }

    private void OnTriggerEnter2D(Collider2D collider) {
      birdRigidbody2D.bodyType = RigidbodyType2D.Static;
      if (OnDied != null) OnDied(this, EventArgs.Empty);
=======
      SoundManager.PlaySound();
     //   SoundManager.PlaySound(SoundManager.Sound.BirdJump);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
     
      birdRigidbody2D.bodyType=RigidbodyType2D.Static;
    //  SoundManager.PlaySound(SoundManager.Sound.Lose);
      if(OnDied!=null){
        OnDied(this,EventArgs.Empty);
      }
>>>>>>> demo-branch
    }
}
