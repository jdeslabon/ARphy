using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityForce : MonoBehaviour
{
    public float forceMagnitude = 9.81f; // Magnitude of the gravitational force
   
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(180, 0, 0);
    }
}