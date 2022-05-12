using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TailTurn : MonoBehaviour
{
    private float turnSpeed= 3000f;
   
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
