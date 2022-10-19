using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : States
{
    public override States RunCurrentSate()
    {
        Debug.Log("Begone Fairy");
        return this;
    }
}
