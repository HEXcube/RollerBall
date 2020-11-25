using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour {
    public float xrotation = 15, yrotation = 30, zrotation = 45;
    
    void Update () 
    {
        transform.Rotate (new Vector3 (xrotation, yrotation, zrotation) * Time.deltaTime);
    }
}

