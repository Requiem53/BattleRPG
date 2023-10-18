using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : CharacterClass
{
    //Class Name
    //Strength
    //Resilience
    //Agility
    //Wisdom
    //Luck

    public Warrior(){
        StatsSetter();
    }

    public override void StatsSetter()
    {
        _className = "Warrior";
        _strength = 10;
        _resilience = 10;
        _agility = 10;
        _wisdom = 10;
        _luck = 10;
    }

    public override void InitializeClass()
    {
        throw new System.NotImplementedException();
    }

    public override void LevelUp()
    {
        throw new System.NotImplementedException();
    } 
}