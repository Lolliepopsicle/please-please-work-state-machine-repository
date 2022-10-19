using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : States
{
    public ChaseState chaseState;
    public bool canSeeThePLayer;
    public override States RunCurrentSate()
    {
        if (canSeeThePLayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }
}
