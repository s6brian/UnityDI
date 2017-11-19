using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class TextDamage : MonoBehaviour {
	// private static TextDamage m_instance;
	// public static TextDamage Instance {get { return m_instance; }}

	[SerializeField] private Text m_uiText;

	void Awake () {
		// m_instance = this;
		// m_uiText = this.GetComponent<Text>();

		Assert.IsNotNull(m_uiText);
	}

	void Start () {
		Color c = Color.white;
		c.a = 0.0f;
		m_uiText.color = c;
	}

	public void DisplayDamage (int p_damage) {
		m_uiText.color = Color.white;
		m_uiText.text = p_damage.ToString();
		
		StopCoroutine("FadeOut");
		StartCoroutine("FadeOut");
	}

	IEnumerator FadeOut () {
		yield return new WaitForSeconds(1.0f);
		
		Color c = m_uiText.color;

		while(c.a > 0) {
			c.a -= 0.1f;
			m_uiText.color = c;
			yield return new WaitForSeconds(0.1f);
		}
	}
}
