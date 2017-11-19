using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour, IKeyActionListener {

	[SerializeField] private TextDamagePooler m_textDamage;

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
		int damage = GetDamage();

		if(damage < 80) {
			m_textDamage.DisplayDamage (damage);
		}
		else {
			m_textDamage.DisplayCriticalDamage(damage);
		}
	}

	int GetDamage () {
		return Random.Range(20, 100);
	}
}
