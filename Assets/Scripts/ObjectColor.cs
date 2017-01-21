using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour
{

	public Color changedColor = Color.white;
	public Color originalColor = Color.white;
	public Renderer rend;

	void Start(){
		rend = GetComponent<Renderer> ();
		originalColor = rend.material.color;
	}
		
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.G)) {
			EnableColor ();
		} else if (Input.GetKeyUp (KeyCode.G)) {
			DisableColor ();
		}
	}

	public void EnableColor ()
	{
		rend.material.color = changedColor;
	}

	public void DisableColor ()
	{
		rend.material.color = originalColor;
	}
}
