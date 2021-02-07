using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject cherry;
    public float spawnRate = 4f;
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
            spawnLocation = new Vector2(Random.Range(-8.9f, -5.5f), Random.Range(-0.6f, 4.3f));
            Instantiate(cherry, spawnLocation, Quaternion.identity);
        }
    }

}