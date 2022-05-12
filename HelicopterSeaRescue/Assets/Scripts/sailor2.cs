using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class sailor2 : DrownTimer
{
    // Start is called before the first frame update
    private void Update()
    {
        
    }

    public override void CheckRemainingTime()
    {

        //  POLYMORPHISM
        timeToDeath = 3.0f;
        if (timeRemaining > timeToDeath)
        {
            Destroy(gameObject);
        }
    }
}
