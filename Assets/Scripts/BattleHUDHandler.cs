using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHUDHandler : MonoBehaviour
{
    private void OnEnable(){
        Stats.OnCreation += InstantiateHUD;
    }

    private void OnDisable(){
        Stats.OnCreation -= InstantiateHUD;
    }

    [SerializeField] private BattleHUD parentHUD;

    private void InstantiateHUD(Stats stats){
        BattleHUD hud = Instantiate(parentHUD, transform);
        hud.setStats(stats);
        hud.name = stats.cName() + " Stats";
    }
}
