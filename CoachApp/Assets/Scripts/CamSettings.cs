using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSettings : MonoBehaviour {

    Camera cam { get { return Camera.main; } }

	// Use this for initialization
	void Start () {
        cam.aspect = (Screen.currentResolution.width / (float)Screen.currentResolution.height);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
