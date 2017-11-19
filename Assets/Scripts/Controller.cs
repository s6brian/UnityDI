using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Controller : IKeyActionEvents {
	
	// private List<IKeyActionListener> m_keyActionListeners = new List<IKeyActionListener>();

	// public void AddKeyActionListener (IKeyActionListener p_keyActionListener) {
	// 	m_keyActionListeners.Add(p_keyActionListener);
	// }

	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			foreach (IKeyActionListener keyActionListener in m_keyActionListeners) {
				keyActionListener.OnKeyDown(KeyCode.F);
			}
		}
	}
}
