using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour {

   
    int length = 50; 
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(280 + Mathf.PingPong(Time.time * 20, length), transform.position.y, transform.position.z);
	}
}
