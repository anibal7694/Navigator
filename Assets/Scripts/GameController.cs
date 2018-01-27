using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    RaycastHit hitInfo;
    public GameObject selectedObj;
    // Use this for initialization
    void Start () {
        hitInfo = new RaycastHit();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                if(hitInfo.transform.tag=="player")
                {
                    hitInfo.transform.gameObject.GetComponent<NavigationController>().enabled = true;
                    hitInfo.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    if (selectedObj != null)
                    {
                        selectedObj.GetComponent<MeshRenderer>().material.color = Color.green;
                        selectedObj.GetComponent<NavigationController>().enabled = false;
                    }
                    selectedObj = hitInfo.transform.gameObject;
                    
                }
                else
                {
                    if (selectedObj != null)
                    {
                        selectedObj.GetComponent<NavigationController>().destination = new Vector3(hitInfo.point.x, 1.0f, hitInfo.point.z);
                        selectedObj.GetComponent<NavigationController>().start = true;
                    }
                }
            }
        }
    }
}
