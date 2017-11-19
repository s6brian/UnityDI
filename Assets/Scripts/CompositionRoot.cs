using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CompositionRoot : MonoBehaviour {
	[SerializeField] private Player m_player;
	[SerializeField] private Controller m_controller;

	// Use this for initialization
	void Awake () {
		Assert.IsNotNull(m_player);
		Assert.IsNotNull(m_controller);

		m_controller.AddKeyActionListener(m_player);
	}
}
