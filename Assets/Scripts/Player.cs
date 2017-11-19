using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int GetDamage () {
		return Random.Range(20, 100);
	}
}
