using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDamage : MonoBehaviour
{
	Text m_uiText;

	void Awake () {
		m_uiText = this.GetComponent<Text>();
		
		Color c = Color.white;
		c.a = 0.0f;
		m_uiText.color = c;

		// DisplayDamage(300);
	}

	void DisplayDamage (int p_damage) {
		m_uiText.color = Color.white;
		m_uiText.text = p_damage.ToString();
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
