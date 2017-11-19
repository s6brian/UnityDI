using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class TextDamage : MonoBehaviour {

	[SerializeField] private Text m_uiText;
	Transform m_transform;

	void Awake () {
		// m_instance = this;
		// m_uiText = this.GetComponent<Text>();

		Assert.IsNotNull(m_uiText);
		m_transform = this.transform;
	}

	void Start () {
		Color c = Color.white;
		c.a = 0.0f;
		m_uiText.color = c;
	}

	public void DisplayDamage (int p_damage) {
		m_uiText.fontSize = 100;
		m_uiText.color = Color.white;
		m_uiText.text = p_damage.ToString();

		Animate();
	}

	public void DisplayCriticalDamage (int p_damage) {
		m_uiText.fontSize = 120;
		m_uiText.color = Color.red;
		m_uiText.text = p_damage.ToString();

		Animate();
	}

	void Animate() {
		m_transform.localPosition = Vector3.zero;
		
		StopCoroutine ("Shrink");
		StartCoroutine("Shrink");

		StopCoroutine ("EaseOut");
		StartCoroutine("EaseOut");

		StopCoroutine ("FadeOut");
		StartCoroutine("FadeOut");
	}

	IEnumerator Shrink () {
		while (m_uiText.color.a > 0f) {
			m_uiText.fontSize -= 5;
			yield return new WaitForSeconds(Time.deltaTime * 5f);
		}
	}

	IEnumerator EaseOut () {
		Vector3 pos = m_transform.localPosition;

		float x;
		float t = 0f;

		while (m_uiText.color.a > 0f) {
			x  = Time.deltaTime * 300f;
			t += Time.deltaTime * 2;
			
			pos.x += x;
			pos.y += Mathf.Cos(t) * x;
			m_transform.localPosition = pos;
			
			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator FadeOut () {
		yield return new WaitForSeconds(1.0f);
		
		Color c = m_uiText.color;

		while(c.a > 0) {
			c.a -= 0.1f;
			m_uiText.color = c;
			yield return new WaitForEndOfFrame();
		}
	}
}
