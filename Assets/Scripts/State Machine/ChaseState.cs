using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : States
{
    public AttackState attackState;
    public bool IsInAttackRange;
    public override States RunCurrentSate()
    {
        if (IsInAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;
        }
    }
}
