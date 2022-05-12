using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownTimer : MonoBehaviour
{
    private float startTime;
    public float timeToDeath;
    public float timeRemaining;
    public GrappleDown catchedSailor;


    void Awake()
    {
        startTime = Time.time;
        catchedSailor = GameObject.Find("floaty").GetComponent<GrappleDown>();
    }

   
    void Update()
    {
        timeRemaining = Time.time - startTime;
        checkRemainingTime();
    }

    //INHERITANCE
    public virtual void checkRemainingTime()
    {
        timeToDeath = 10f;
        if (!catchedSailor.catchSailor && (timeRemaining > timeToDeath))
        {
        Destroy(gameObject);
        
        }
        if(catchedSailor.catchSailor)
        {
            Debug.Log("hi  you saved him");
            transform.position = catchedSailor.ball.transform.position;
        }
    }

    
}
