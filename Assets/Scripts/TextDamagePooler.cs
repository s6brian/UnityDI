using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class TextDamagePooler : MonoBehaviour {
	const int MAX_TEXT_DAMAGE_COUNT = 20;

	[SerializeField] private TextDamage m_textDamage;

	List<TextDamage> m_textDamages = new List<TextDamage>();
	int m_index = 0;

	void Awake () {
		Assert.IsNotNull(m_textDamage);
	}

	void Start () {
		m_textDamages.Add(m_textDamage);

		for (int idx = 1; idx < MAX_TEXT_DAMAGE_COUNT; ++idx) {
			Transform t = Instantiate<Transform>(m_textDamage.transform);
			t.SetParent(this.transform);
			t.localPosition = Vector3.zero;
			t.localScale = Vector3.one;

			m_textDamages.Add(t.GetComponent<TextDamage>());
		}
	}

	public void DisplayDamage (int p_damage) {
		m_textDamages[++m_index % MAX_TEXT_DAMAGE_COUNT].DisplayDamage(p_damage);
	}

	public void DisplayCriticalDamage (int p_damage) {
		m_textDamages[++m_index % MAX_TEXT_DAMAGE_COUNT].DisplayCriticalDamage(p_damage);
	}
}
