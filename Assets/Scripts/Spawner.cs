using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject SpawnType = null;
	public float scaleMin = 0.2f;
	public float scaleMax = 1.0f;

	void Update ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			
			GameObject obj = Instantiate (SpawnType) as GameObject;

			obj.transform.position = this.transform.position;


			float scaleSize = Random.Range (scaleMin, scaleMax);
			obj.transform.localScale = Vector3.one * scaleSize;
			obj.AddComponent<Rigidbody> ().AddForce(-transform.forward * 1000); //Vector3.back

			obj.name = "mySphere";
		}
	}
}
