using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    Quaternion currentGyro;

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        currentGyro = Input.gyro.attitude;
        this.transform.localRotation = Quaternion.Euler(90, 90, 0) * (new Quaternion(-currentGyro.x, -currentGyro.y, currentGyro.z, currentGyro.w));
		
	}
}
