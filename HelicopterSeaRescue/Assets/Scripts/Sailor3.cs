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
        DieSailorDie();

    }
}
