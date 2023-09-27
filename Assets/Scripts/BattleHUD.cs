using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    private Stats _stats;
    private TMPro.TextMeshProUGUI _displayText;

    public void setStats(Stats stats){
        _stats = stats;
        GetComponent<RectTransform>().anchoredPosition = new Vector3(stats.transform.position.x, stats.transform.position.y, 1f);
        _displayText = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        _displayText.text = "Health <br> Break";
    }

}
