using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2f;
    float nextSpawn = 0;
    Vector2 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //repeats enemy spawns at specific location at intervals and proper orientation
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            spawnLocation = new Vector2(8.3f, -0.3f);
            Instantiate(enemy, spawnLocation, Quaternion.identity);
        }
    }

}
