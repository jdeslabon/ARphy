using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionForce : MonoBehaviour
{
    public Transform movingObject;

    void Update()
    {
        if (movingObject != null)
        {
            Vector3 oppositeDirection = -movingObject.forward;
            transform.rotation =
                Quaternion.LookRotation(oppositeDirection);
        }
    }
}