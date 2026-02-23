using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public void Fire(Vector3 velocity, Vector3 origin)
    {
        gameObject.SetActive(true);
        transform.position = origin;
        GetComponent<Rigidbody>().velocity = velocity;
        Destroy(gameObject, 10);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Destroy(collision.gameObject);
            collision.gameObject.SendMessage("TakeDamage", 1);
            Destroy(gameObject);
        }
    }
}