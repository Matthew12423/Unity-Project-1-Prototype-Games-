using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 5;
    public float maxHealth = 5;
    public bool dead = false;

    public void TakeDamage(float damage)
    {
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        FindObjectOfType<GameHandler>().playerHealth(health/ maxHealth);
        if(health <=0)
        {
            GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
            dead = true;
        }
    }

}
