using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExamples : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object: " + other.name + " entered trigger.");
	}
}
