using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    private GameObject player;
    public NavMeshAgent agent;

    public float attackPower = 5;
    public float attackRate = 1;
    private float lastAttack = float.MinValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if (player)
        {
            agent.SetDestination(player.transform.position);
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(Time.time > lastAttack + attackRate)
            {
                Attack(other);
            }
        }
    }

    private void Attack(Collider other)
    {
        lastAttack = Time.time;
        other.gameObject.SendMessage("TakeDamage", attackPower);
    }
}
