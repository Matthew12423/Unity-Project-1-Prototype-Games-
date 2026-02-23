using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public UIHandler uiHandler;
    public float time = 300;

    // Start is called before the first frame update
    void Start()
    {
        uiHandler.SetKills(kills);
    }

    // Update is called once per frame
    void Update()
    {
        time = Mathf.Clamp(time - Time.deltaTime, 0, float.MaxValue);
        uiHandler.SetTimer(time);
    }

    public void PlayerHealth(float percent)
    {
        uiHandler.SetHealthBar(percent);
    }

    int kills = 0;
    public void EnemyDeath()
    {
        kills += 1;
        uiHandler.SetKills(kills);
    }
}
