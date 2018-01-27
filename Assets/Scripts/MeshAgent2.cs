using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshAgent2 : MonoBehaviour
{
    public bool select;
    Vector3 movePos;
   
    // Use this for initialization
  
    void Start()
    {
        select = false; 
        
    }
    

    // Update is called once per frame
    public void Update()
    {
            MoveObject();
    }
    void MoveObject()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Got Input Key");
            movePos = this.gameObject.transform.position;
            movePos = new Vector3(movePos.x, movePos.y, movePos.z + 2);
            this.gameObject.transform.position = movePos;
            Debug.Log("Done Moving");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Got Input Key");
            movePos = this.gameObject.transform.position;
            movePos = new Vector3(movePos.x, movePos.y, movePos.z - 2);
            this.gameObject.transform.position = movePos;
            Debug.Log("Done Moving");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Got Input Key");
            movePos = this.gameObject.transform.position;
            movePos = new Vector3(movePos.x - 2, movePos.y, movePos.z);
            this.gameObject.transform.position = movePos;
            Debug.Log("Done Moving");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Got Input Key");
            movePos = this.gameObject.transform.position;
            movePos = new Vector3(movePos.x + 2, movePos.y, movePos.z);
            this.gameObject.transform.position = movePos;
            Debug.Log("Done Moving");
        }
    }
}