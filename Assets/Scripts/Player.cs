using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour, IKeyActionListener {

	[SerializeField] private TextDamage m_textDamage;

	void Awake () {
		Assert.IsNotNull(m_textDamage);
	}

	public void OnKeyDown (KeyCode p_keycode) {
		switch (p_keycode) {
			case KeyCode.F:
			{
				OnDamage();
				break;
			}
		}
	}

	void OnDamage () {
		m_textDamage.DisplayDamage (GetDamage());
	}

	int GetDamage () {
		return Random.Range(20, 100);
	}
}
