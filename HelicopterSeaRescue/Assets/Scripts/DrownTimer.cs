using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownTimer : MonoBehaviour
{
    public float startTime;
    public float timeToDeath;
    public float timeRemaining;
    public GrappleDown catchedSailor;
    public bool sailorIsSafe = false;
    [SerializeField]
    private HealthBar healthBar;
    


    void Awake()
    {
        startTime = Time.time;
        catchedSailor = GameObject.Find("floaty").GetComponent<GrappleDown>();
        healthBar.UpdateTimeToDrown(1.0f, 1.0f);
    }


    void Update()
    {
        timeRemaining = Time.time - startTime;
        CheckRemainingTime();
        CheckIfSafe();
        healthBar.UpdateTimeToDrown(timeRemaining, timeToDeath);
        

    }
    //INHERITANCE
    public virtual void CheckRemainingTime()
    {
        timeToDeath = 30f;
        if (!catchedSailor.catchSailor && (timeRemaining > timeToDeath))
        {
        Destroy(gameObject);
        //ADD ONE SAILOR TO DEATH COUNT
        }
        if(catchedSailor.catchSailor)
        {
      
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
