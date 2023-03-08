using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject Box;

	private void ExecuteTrigger(string trigger) {
		if (Box != null) {
			var reset = Box.GetComponent<Fractal>();
			if (reset != null){
				//reset.SetTrigger(trigger);
			}
		}
	}

	void OnClick(){
		ExecuteTrigger("Click");
	}
}
