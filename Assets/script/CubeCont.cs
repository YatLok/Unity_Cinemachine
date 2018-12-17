using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCont : MonoBehaviour {


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.Translate(-2f, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            this.transform.Translate(2f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 2f);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            this.transform.Translate(0.0f, 0.0f, -2f);
        }
		
	}
}
