using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugController : IKeyActionEvents {
	const float DELAY = 0.5f;

	private float m_lapsTime = DELAY;

	void Start () {
		foreach (IKeyActionListener keyActionListener in m_keyActionListeners) {
			keyActionListener.OnKeyDown(KeyCode.F);
		}
	}

	void Update () {
		
		if(m_lapsTime > 0.0f) {
			m_lapsTime -= Time.deltaTime;
		}
		else {
			m_lapsTime = DELAY;

			foreach (IKeyActionListener keyActionListener in m_keyActionListeners) {
				keyActionListener.OnKeyDown(KeyCode.F);
			}
		}
	}
}
