using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]



public class MoveCharacter : MonoBehaviour {

    CharacterController cc;
    
	
	void Start () {
        cc = GetComponent<CharacterController>();
        moveinput.KeyAction = Move; 
		
	}
	
	// Update is called once per frame
	void Move (float _movement) {
        print(_movement);
   
		}
}
