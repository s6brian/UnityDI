using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

// for simplicity, use abstract instead of interface
// you may explore https://github.com/vexe/VFW to expose interfaces in the inspector
public class Player : IKeyActionListener { //MonoBehaviour, IKeyActionListener {

	[SerializeField] private TextDamage m_textDamage;

	// void OnEnable () {
	// 	Controller.OnFKeyDown += OnDamage;
	// }

	// void OnDisable () {
	// 	Controller.OnFKeyDown -= OnDamage;
	// }

	void Awake () {
		Assert.IsNotNull(m_textDamage);
	}

	public override void OnKeyDown (KeyCode p_keycode) {
		switch (p_keycode) {
			case KeyCode.F:
			{
				OnDamage();
				break;
			}
		}
	}

	void OnDamage () {
		// TextDamage.Instance.DisplayDamage(GetDamage());
		m_textDamage.DisplayDamage (GetDamage());
	}

	int GetDamage () {
		return Random.Range(20, 100);
	}
}
