using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public delegate void KeyAction();
	public static event KeyAction OnFKeyDown; 

	void Update () {
		if (Input.GetKeyDown (KeyCode.F) && OnFKeyDown != null) {
			// do action
			OnFKeyDown();
		}
	}
}
