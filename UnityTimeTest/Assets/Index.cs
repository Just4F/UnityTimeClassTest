using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var test = gameObject.AddComponent<TimeScaleTest>();
        test.TimeScaleSet = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
