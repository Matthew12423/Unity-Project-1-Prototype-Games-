using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Projectile projectilePrefab;
    public Transform muzzle;
    public float muzzleVelocity = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //left click 0; right 1; middle 2...
        {
            Projectile projectile = Instantiate(projectilePrefab);
            projectile.Fire(muzzleVelocity * muzzle.forward, muzzle.transform.position);
        }
    }

    
}
