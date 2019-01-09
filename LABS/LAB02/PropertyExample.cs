using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyExample : MonoBehaviour
{
    void Start()
    {
        // You CAN do the following:
        transform.position = Vector3.zero;
        Vector3 vectorVarible = transform.position;

        // You CANNOT always do the following
        // transform.position += Vector3.one;

        // INSTEAD Get, Process, then Set
        // Get
        Vector3 processVector = transform.position;
        // Process
        processVector += Vector3.one;
        // Set
        transform.position = processVector; 


    }


}
