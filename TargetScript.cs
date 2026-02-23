using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public int health = 1;
    public Renderer myRenderer;
    public Color[] damageColors;

    public void TakeDamage(int damage)
    {
        health = Mathf.Clamp(health - damage, 0, int.MaxValue);
        //Color color = damageColors[health];
        //myRenderer.material.color = color;
        if(health <= 0)
        {
            FindObjectOfType<GameHandler>().EnemyDeath();
            Destroy(gameObject);
        }
    }
}

