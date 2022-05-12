using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerTurn : MonoBehaviour
{
    private float turnSpeed = 3000f;
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
}
