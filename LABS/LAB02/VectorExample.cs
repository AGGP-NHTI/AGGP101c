using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    void Start()
    {
        Vector3 vectorVariable = Vector3.one;
        vectorVariable.x = 3.5f;
        vectorVariable.y = 1.0f;
        vectorVariable.z = -2.6f;
        Debug.Log("vectorVariable " + vectorVariable.ToString());
    }
}
