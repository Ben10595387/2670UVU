using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))] //automatically adds character controller in unity//



public class MoveCharacter : MonoBehaviour {

	public static Action<float> KeyAction;
	
	public static Action<bool> JumpAction;

	CharacterController cc;

	Vector3 tempmove = Vector3.zero;
	
	public float speed = 5;

	public float gravity = 1;

	public float jumpHeight = 0.2f;

	public float jumpAmount = 0.0f;

	float maxJumpCount = 2.0f;
	
    
	void Start () {
		
		cc = GetComponent<CharacterController>();
		PlayButton.pushedPlay += OnPlay;

	}
	
	void OnPlay () {
        cc = GetComponent<CharacterController>();
        moveinput.KeyAction += Move; 
		PlayButton.pushedPlay -= OnPlay;
		//to make the character have the animation as
		//well as this script work. It must be += instead of just = Move on both scripts. 
		
	}

	void Move (float _movement) {
       // print(_movement);
		tempmove.y -= gravity*Time.deltaTime;
		tempmove.x =_movement*speed*Time.deltaTime * speed;
		cc.Move(tempmove);
		//script is only recieving float
   
		}

	void Jump(bool obj) {
		if (!cc.isGrounded) {
			tempmove.x = Input.GetAxis("Horizontal")*speed;
		}
		else {
			tempmove = new Vector3(Input.GetAxis("Horizontal")*speed, 0.0f, Input.GetAxis("Vertical")*speed);
			jumpAmount = 0.0f;
		}

		if (jumpAmount < maxJumpCount){
			if (Input.GetKeyDown ("Jump")) {
				tempmove.y += jumpHeight;
				jumpAmount = 2.0f;
			}
		}
		//print("Jumped");
	}
}
