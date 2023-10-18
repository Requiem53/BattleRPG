using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitAction
{
    public Stats actor;
    public abstract void Execute();

    public void assignActor(Stats actor){
        this.actor = actor;
    }
}
