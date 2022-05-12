using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownTimer : MonoBehaviour
{
    private float startTime;
    public float timeToDeath;
    public float timeRemaining;
    public GrappleDown catchedSailor;
    public bool sailorIsSafe = false;
    


    void Awake()
    {
        startTime = Time.time;
        catchedSailor = GameObject.Find("floaty").GetComponent<GrappleDown>();
    }

   
    void Update()
    {
        timeRemaining = Time.time - startTime;
        CheckRemainingTime();
        CheckIfSafe();
    }

    //INHERITANCE
    public virtual void CheckRemainingTime()
    {
        timeToDeath = 10f;
        if (!catchedSailor.catchSailor && (timeRemaining > timeToDeath))
        {
        Destroy(gameObject);
        //ADD ONE SAILOR TO DEATH COUNT
        }
        if(catchedSailor.catchSailor)
        {
            Debug.Log("hi  you saved him");
            transform.position = catchedSailor.ball.transform.position;
        }
    }

    public void CheckIfSafe()
    {
        if (sailorIsSafe)
        {
            Destroy(gameObject);
            //ADD ONE SAVED SAILOR TO COUNTER
        }
    }
    
}
