using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxMana;
    [SerializeField] private int _currentHealth;
    [SerializeField] private int _currentMana;

    public static event Action<Stats> OnCreation;

    private void Start(){
        OnCreation?.Invoke(this);
    }

}
