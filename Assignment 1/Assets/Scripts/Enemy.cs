using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int cherryValue = -3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //deducts points when colliding with enemy
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(cherryValue);
        }

    }
}
