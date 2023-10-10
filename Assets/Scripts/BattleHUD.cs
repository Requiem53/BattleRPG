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
        _displayText = GetComponentInChildren<TextMeshProUGUI>();
        GetComponent<RectTransform>().anchoredPosition = new Vector2(_stats.transform.position.x * 100 + 40, (_stats.transform.position.y)*100 + 140);
        validateText();
    }

    public void validateText(){
        _displayText.text = _stats.cName() + "<br>" +_stats.currentHealth() + "/" + _stats.maxHealth();
    }

}
