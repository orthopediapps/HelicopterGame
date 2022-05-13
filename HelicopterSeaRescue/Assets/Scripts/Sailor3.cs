using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  INHERITANCE
public class Sailor3 : DrownTimer
{
    // Start is called before the first frame update
    

    public override void CheckRemainingTime()
    {
        // POLYMORPHISM

        timeToDeath = 60f;
        if (!catchedSailor.catchSailor && (timeRemaining > timeToDeath))
        {
            Destroy(gameObject);
            //ADD ONE SAILOR TO DEATH COUNT
        }
        if (catchedSailor.catchSailor)
        {
            
            transform.position = catchedSailor.ball.transform.position;
        }
    }
}
