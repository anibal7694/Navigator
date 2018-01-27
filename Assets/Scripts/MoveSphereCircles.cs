using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphereCircles : MonoBehaviour
{

    float orbitSpeed = 10;
    void Update()
    {
        transform.RotateAround(transform.position, new Vector3(0, 5, 0), orbitSpeed * Time.deltaTime);
    }
}
