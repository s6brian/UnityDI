using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// for simplicity, use abstract instead of interface
// you may explore https://github.com/vexe/VFW to expose interfaces in the inspector
// public interface IKeyActionListener {
public abstract class IKeyActionListener : MonoBehaviour {
	public virtual void OnKeyDown(KeyCode p_keycode){}
}
