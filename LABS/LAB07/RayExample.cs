using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RayExample : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        RayExampleCode();

    }

    // Update is called once per frame
    void Update()
    {
        DrawDebugRay();
    }

    public void RayExampleCode()
    {
        Ray rayExample = new Ray();
        rayExample.origin = Vector3.zero;
        // aka (0,0,0)
        rayExample.direction = Vector3.forward;
        // aka (0,0,1)
        Vector3 point = rayExample.GetPoint(13);
        // aka 13 * (0,0,1) or (0,0,13)
        Debug.Log("My point 13 units on the ray is " + point.ToString());
    }

    public void DrawDebugRay()
    {
        float drawLength = 25.0f;
        Vector3 origin = gameObject.transform.position;
        Vector3 direction = origin + (gameObject.transform.forward * drawLength); ;
        Color drawColor = Color.red;

        Debug.DrawRay(origin, direction, drawColor);
    }
}
