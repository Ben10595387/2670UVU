using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //namespace system contains actions//

public class moveinput : MonoBehaviour {


	public static Action<float> KeyAction;
	public static Action JumpAction;

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) )
	{
			JumpAction();
	}

		if (KeyAction != null)
		{
			KeyAction(Input.GetAxis("Horizontal"));
		}
		
	}
}
