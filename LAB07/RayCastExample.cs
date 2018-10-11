using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastExample : MonoBehaviour {
    public bool CheckForAllHits = false;
    public float CheckDistance = 50.0f; 
    public bool HasFoundObject = false; 
    public string FoundObject = "";
    public Vector3 HitAtPoint = Vector3.zero;
    public Vector3 HitAtNormal = Vector3.zero;
    public List<string> FoundObjectList; 

	void Update () {
        if (CheckForAllHits)
        {
            MultipleHitCheck();
        }
        else
        {
            SingleHitCheck();        }
	}

   

    public void SingleHitCheck()
    {
        Util_ResetEditorPublics();

        RaycastHit hit;
        bool hashit = Physics.Raycast(transform.position, transform.forward, out hit, CheckDistance); 
        if (hashit)
        {
            Util_ProcessHit(hit);
        }
    }

    public void MultipleHitCheck()
    {
        Util_ResetEditorPublics();
        FoundObjectList.Clear(); 

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, CheckDistance);

        foreach (RaycastHit hit in hits)
        {
            Util_ProcessHit(hit);
            FoundObjectList.Add(hit.collider.gameObject.name); 
        }
    }
    public void Util_ResetEditorPublics()
    {
        HasFoundObject = false;
        FoundObject = "";
        HitAtPoint = Vector3.zero;
        HitAtNormal = Vector3.zero;
    }

    public void Util_ProcessHit(RaycastHit hit)
    {
        HasFoundObject = true;
        FoundObject = hit.collider.gameObject.name;
        HitAtPoint = hit.point;
        HitAtNormal = hit.normal;
    }
}
