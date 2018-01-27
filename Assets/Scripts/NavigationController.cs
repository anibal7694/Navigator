using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationController : MonoBehaviour {

    NavMeshAgent agent;
    public Vector3 destination;
    public bool start;
	// Use this for initialization
	void Start () {
        start = false;
        agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if(start)
        agent.SetDestination(destination);
	}
}
