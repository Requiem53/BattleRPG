using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    private Stats _stats;
    private TextMeshProUGUI _displayText;

    public void setStats(Stats stats){
        _stats = stats;
        GetComponent<RectTransform>().anchoredPosition = new Vector2(_stats.transform.position.x, _stats.transform.position.y);
        _displayText = GetComponentInChildren<TextMeshProUGUI>();
        validateText();
    }

    public void validateText(){
        _displayText.text = _stats.cName() + "<br>" +_stats.currentHealth() + "/" + _stats.maxHealth();
    }

}
