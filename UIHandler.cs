using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Transform bossHealth;
    private float bossHealthMaxLength;
    public Text timerText;
    public Transform playerHealth;
    private float playerHealthMaxLength;
    // Start is called before the first frame update
    void Start()
    {
        playerHealthMaxLength = playerHealth.localScale.x;
        bossHealthMaxLength = bossHealth.localScale.x;
    }

    public void SetTimer(float time)
    {
        timerText.text = Utility.FormatTime(time);
    }

    public void SetplayerHealth(float percent)
    {
        Vector3 scale = playerHealth.localScale;
        playerHealth.localScale = new Vector3(playerHealthMaxLength * percent, scale.y, scale.z);
    }
    public void SetbossHealth(float percent)
    {
        Vector3 scale = bossHealth.localScale;
        bossHealth.localScale = new Vector3(bossHealthMaxLength * percent, scale.y, scale.z);
    }
}