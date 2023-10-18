using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDebugger : MonoBehaviour
{
    [SerializeField] private Stats attacker;
    [SerializeField] private Stats receiver;
    UnitAction action;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            action = new Strike(attacker, receiver);
            attacker.DoAction(action);
        }
    }
}
