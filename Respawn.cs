using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public float minYRespawn = -5;

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < minYRespawn)
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            player.position = transform.position;
        }
    }
}
