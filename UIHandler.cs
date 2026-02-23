using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Text timerText;
    public Transform healthBar;
    private float healthBarMaxLength;
    public Text killsText;
    // Start is called before the first frame update
    void Start()
    {
        healthBarMaxLength = healthBar.localScale.x;
    }

    public void SetTimer(float time)
    {
        timerText.text = Utility.FormatTime(time);
    }

    public void SetHealthBar(float percent)
    {
        Vector3 scale = healthBar.localScale;
        healthBar.localScale = new Vector3(healthBarMaxLength * percent, scale.y, scale.z);
    }
    public void SetKills(int value)
    {
        killsText.text = value. ToString();
    }
}
