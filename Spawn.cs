using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 10;
    private float lastSpawn;
    public int maxCount = 10;
    private int count = 0;
    // Start is called before the first frame update
    void OnEnabled()
    {
        lastSpawn = Time.time - spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(count <= maxCount && Time.time > lastSpawn + spawnRate)
        {
            count += 1;
            lastSpawn = Time.time;
            Debug.Log(gameObject.name);
            Instantiate(enemyPrefab,transform.position,Quaternion.identity);
        }
    }
}
