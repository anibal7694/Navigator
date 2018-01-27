using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Director : MonoBehaviour
{

    RaycastHit hitInfo;
    public GameObject selectedObj;
    public GameObject[] selectedObject = new GameObject[5];
    int i = 0;
    int n = 0;
    // Use this for initialization
    void Start()
    {
        hitInfo = new RaycastHit();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.LeftControl))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log("Using two conditions");

            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {

                if (hitInfo.transform.tag == "player")
                {
                    selectedObject[i] = hitInfo.transform.gameObject;
                    
                    if(selectedObject[i] != null)
                        hitInfo.transform.gameObject.GetComponent<MeshAgent1>().enabled = true;
                    
                    Debug.Log(selectedObject[i]);
                    i = i + 1;
                    if (i > 4)
                        i = 0;
                    
                }
                else
                {
                    for (n = 0; n < i; n++)
                    {
                        Debug.Log(n);
                        selectedObject[n].GetComponent<MeshAgent1>().destination = hitInfo.point;
                        selectedObject[n].GetComponent<MeshAgent1>().start = true;
                        selectedObject[n] = null;
                    }
                    i = 0;
                    
                }
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("Using one condition");
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                if (hitInfo.transform.tag == "player")
                {
                    hitInfo.transform.gameObject.GetComponent<MeshAgent1>().enabled = true;
                    hitInfo.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    if (selectedObj != null)
                    {
                        selectedObj.GetComponent<MeshRenderer>().material.color = Color.green;
                        selectedObj.GetComponent<MeshAgent1>().enabled = false;
                    }
                    selectedObj = hitInfo.transform.gameObject;

                }
                else
                {
                    if (selectedObj != null)
                    {
                        selectedObj.GetComponent<MeshAgent1>().destination = new Vector3(hitInfo.point.x, 1.0f, hitInfo.point.z);
                        selectedObj.GetComponent<MeshAgent1>().start = true;
                    }
                }

            }


        }
    }
}
