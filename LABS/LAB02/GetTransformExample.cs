using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTransformExample : MonoBehaviour
{
    // This area is where Class Variables
    // Are typically created

    //We can store a reference in a Transform variable
    Transform transf;

    void Start()
    {
        // #1
        // Use the Script’s Transform property
        transf = transform;

        // #2
        // Use the Script’s gameObject property to access its Transform Property
        transf = gameObject.transform;

        // #3
        // Use GetComponent in the Script
        transf = GetComponent<Transform>();

        // #4
        // Use GetComponent on the Script’s gameObject property
        transf = gameObject.GetComponent<Transform>();

        // Note:
        // If you're using #1 or #3 and Unity isn't acting correctly, 
        // Try using #2 or #4. and get the transform explicity from the gameObject member varible
        // Later on we'll use #2 and #4 with other GameObject references 
    }
}
