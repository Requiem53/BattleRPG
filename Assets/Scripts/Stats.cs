using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{


    [SerializeField] private string _name;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxMana;
    [SerializeField] private int _currentHealth;
    [SerializeField] private int _currentMana;

    [SerializeField] private CharacterClass _charClass;

    
    public static event Action OnDamage;
    public static event Action<Stats> OnCreation;
    

    private void Start(){
        OnCreation?.Invoke(this);
        _charClass = new Warrior();
        Debug.Log(_charClass);
    }

    public void DoAction(UnitAction action){
        action.Execute();
    }

    public string cName(){
        return _name;
    }

    public int maxHealth(){
        return _maxHealth;
    }

    public int maxMana(){
        return _maxMana;
    }

    public int currentHealth(){
        return _currentHealth;
    }

    public int currentMana(){
        return _currentMana;
    }

    public CharacterClass charClass(){
        return _charClass;
    }

    public void takeDamage(int damage){
        _currentHealth = Math.Max(_currentHealth-damage, 0);
        OnDamage?.Invoke();
    }
    
}
