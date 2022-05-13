using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class sailor2 : DrownTimer
{
    // Start is called before the first frame update

    
    public override void CheckRemainingTime()
    {

        //  POLYMORPHISM
        timeToDeath = 45f;
        if (timeRemaining > timeToDeath)
        {
            Destroy(gameObject);
            //ADD ONE SAILOR TO DEATH COUNT
        }


    }
}
