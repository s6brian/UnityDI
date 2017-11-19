using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Controller : MonoBehaviour {

	// public delegate void KeyAction();
	// public static event KeyAction OnFKeyDown;
	[SerializeField] private IKeyActionListener m_keyActionListener;

	void Awake () {
		Assert.IsNotNull(m_keyActionListener);
	}

	void Update () {
		// if (Input.GetKeyDown (KeyCode.F) && OnFKeyDown != null) {
		// 	// do action
		// 	OnFKeyDown();
		// }

		if (Input.GetKeyDown (KeyCode.F)) {
			m_keyActionListener.OnKeyDown(KeyCode.F);
		}
	}
}
