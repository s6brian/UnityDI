using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IKeyActionEvents: MonoBehaviour {
    // you may also use dictionaries
	// useful in case you want to remove certain listeners using key values
    protected List<IKeyActionListener> m_keyActionListeners = new List<IKeyActionListener>();

	public virtual void AddKeyActionListener (IKeyActionListener p_keyActionListener) {
		m_keyActionListeners.Add(p_keyActionListener);
	}
}
