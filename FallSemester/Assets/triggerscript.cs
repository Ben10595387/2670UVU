using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter() {
        print("Entered");
	}
	
	// Update is called once per frame
	void OnTriggerExit() {
        print("Exited");
	}
}
