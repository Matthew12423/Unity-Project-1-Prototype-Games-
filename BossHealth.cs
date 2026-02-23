using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;
    //public Renderer myRenderer;
    //public Color[] damageColors;

    public void TakeDamage(int damage)
    {
        health = Mathf.Clamp(health - damage, 0, int.MaxValue);
        //Color color = damageColors[health];
        //myRenderer.material.color = color;
        FindObjectOfType<GameHandler>().bossHealth(health/ maxHealth);
        if(health <= 0)
        {
            FindObjectOfType<GameHandler>().EnemyDeath();
            Destroy(gameObject);
        }
    }
}

