using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  INHERITANCE
public class Sailor3 : DrownTimer
{
    // Start is called before the first frame update
    
    public override void checkRemainingTime()
    {
        // POLYMORPHISM

        timeToDeath = 8.0f;
        if (timeRemaining > timeToDeath)
        {
            Destroy(gameObject);
        }
    }
}
