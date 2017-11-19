using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CompositionRoot : MonoBehaviour {
	[SerializeField] private Player m_player;
	// [SerializeField] private Controller m_controller;
	[SerializeField] private IKeyActionEvents m_keyActionEvenDispatcher;

	// Use this for initialization
	void Awake () {
		Assert.IsNotNull(m_player);
		// Assert.IsNotNull(m_controller);
		Assert.IsNotNull(m_keyActionEvenDispatcher);

		// m_controller.AddKeyActionListener(m_player);
		m_keyActionEvenDispatcher.AddKeyActionListener(m_player);
	}
}
