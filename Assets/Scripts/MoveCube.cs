using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCube : MonoBehaviour {

    NavMeshAgent agent;
    Vector3 movePos;

    public GameObject cubes;
    bool select;
    // Use this for initialization
    void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        select = false;
	}

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "NavMeshObstacle")
                {

                    
                    hit.transform.gameObject.GetComponent<MeshAgent2>().enabled = true;
                    //hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = ;
                    if (cubes != null)
                    {
                        cubes.GetComponent<MeshAgent2>().enabled = false;

                    }
                    cubes = hit.transform.gameObject;
                    //GetComponent<MeshAgent2>().select = true;

                }
                //hit.transform.gameObject.GetComponent<MeshAgent2>().enabled = false;

            }
        }
        
    }
}
