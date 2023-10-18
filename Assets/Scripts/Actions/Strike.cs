using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : UnitAction, SingleTarget
{
    Stats target;

    public Strike(Stats actor, Stats target){
        assignActor(actor);
        obtainTarget(target);
    }

    public override void Execute()
    {
        Debug.Log(target.cName() + " was struck by " + actor.cName() + "!");
        target.takeDamage(10);
    }

    public void obtainTarget(Stats target)
    {
        this.target = target;
    }
}
