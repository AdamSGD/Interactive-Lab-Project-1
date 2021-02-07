using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    public int cherryValue = 1;
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
        //counts point when cherry is collected
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(cherryValue);
        }

    }
}
