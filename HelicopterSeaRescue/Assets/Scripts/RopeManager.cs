using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform[] ropePoints;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.positionCount = ropePoints.Length;
        lineRenderer.SetPosition(0, ropePoints[0].position);
        lineRenderer.SetPosition(1, ropePoints[1].position);
    }
}
