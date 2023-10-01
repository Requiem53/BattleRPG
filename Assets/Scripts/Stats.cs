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

    public static event Action<Stats> OnCreation;

    private void Start(){
        OnCreation?.Invoke(this);
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
    
}
