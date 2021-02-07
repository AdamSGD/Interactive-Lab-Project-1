using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 0f;
    public float runSpeed = 40f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keeps value absolute / positive to track animation transition
        animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        //calculating moveSpeed variable
        moveSpeed = Input.GetAxisRaw("Horizontal") * runSpeed;
        //adds vertical force (y-axis) the instant the jump key is pressed down
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        //moves character
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * runSpeed, 0f);
        transform.position += movement * Time.fixedDeltaTime * runSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //destroys a cherry if collision occurs
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
        } 
    }
}
