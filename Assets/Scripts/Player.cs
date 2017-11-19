using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	void OnEnable () {
		Controller.OnFKeyDown += OnDamage;
	}

	void OnDisable () {
		Controller.OnFKeyDown -= OnDamage;
	}

	void OnDamage () {
		TextDamage.Instance.DisplayDamage(GetDamage());
	}

	int GetDamage () {
		return Random.Range(20, 100);
	}
}
