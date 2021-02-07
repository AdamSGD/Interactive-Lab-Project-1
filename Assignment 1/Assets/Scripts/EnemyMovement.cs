using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        //destroys the enemy after a certain amount of time
        Destroy(gameObject, interval);
    }

    // Update is called once per frame
    private void Update()
    {
        //moves the enemy left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
