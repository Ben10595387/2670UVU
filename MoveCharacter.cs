using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))] //automatically adds character controller in unity//



public class MoveCharacter : MonoBehaviour {

    CharacterController cc;

	Vector3 tempmove;

	public float speed = 5;

	public float gravity = 1;

	public float jumpHeight = 0.2f;
    
	void Start () {
		cc = GetComponent<CharacterController>();
		PlayButton.pushedPlay += OnPlay;

	}
	
	void OnPlay () {
        cc = GetComponent<CharacterController>();
        moveinput.KeyAction += Move; 
		moveinput.KeyAction += Jump;
		PlayButton.pushedPlay -= OnPlay;
		//to make the character have the animation as
		//well as this script work. It must be += instead of just = Move on both scripts. 
		
	}

	void Jump() {
		print("jump");
		tempmove.y = jumpHeight;
	}
	
	// Update is called once per frame
	void Move (float _movement) {
       // print(_movement);
		tempmove.y = gravity*Time.deltaTime;
		tempmove.x =_movement*speed*Time.deltaTime;
		cc.Move(tempmove);
		//script is only recieving float
   
		}
}
