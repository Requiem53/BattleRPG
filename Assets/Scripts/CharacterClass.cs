using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterClass
{

    [SerializeField] protected string _className;
    [SerializeField] protected int _strength;
    [SerializeField] protected int _resilience;
    [SerializeField] protected int _agility;
    [SerializeField] protected int _wisdom;
    [SerializeField] protected int _luck;


    public string ClassName { get => _className;}
    public int Strength { get => _strength; set => _strength = value; }
    public int Resilience { get => _resilience; set => _resilience = value; }
    public int Agility { get => _agility; set => _agility = value; }
    public int Wisdom { get => _wisdom; set => _wisdom = value; }
    public int Luck { get => _luck; set => _luck = value; }


    public abstract void StatsSetter();
    public abstract void InitializeClass();
    public abstract void LevelUp();

    public override string ToString(){
        return _className;
    }
}