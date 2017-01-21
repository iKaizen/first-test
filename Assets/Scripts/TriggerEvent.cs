using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class TriggerEvent : MonoBehaviour
{

	public GameObject lightBulb = null;
	public GameObject wall = null;
	public AudioClip lightButton = null;
	AudioSource buttonAudio;

	void Start(){
		buttonAudio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.name == "player") {
			lightBulb.SetActive (true);

			buttonAudio.PlayOneShot (lightButton);

			wall.GetComponent<ObjectScaling> ().EnableScale ();
			wall.GetComponent<ObjectColor> ().EnableColor ();
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.name == "player") {
			lightBulb.SetActive (false);

			buttonAudio.Stop ();

			wall.GetComponent<ObjectScaling> ().DisableScale ();
			wall.GetComponent<ObjectColor> ().DisableColor ();
		}
	}
}
