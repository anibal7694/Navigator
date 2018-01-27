using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongJump : MonoBehaviour {

    int length = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 5 + Mathf.PingPong(Time.time * 20, length), transform.position.z);
    }
}
