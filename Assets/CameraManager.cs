using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraManager : NetworkBehaviour {

	// Use this for initialization
	void Start () {

		if (isLocalPlayer) {
			
			GetComponent<Camera>().enabled = true;
			transform.position = new Vector3 (0f, 1.5f, 2.1f);
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
