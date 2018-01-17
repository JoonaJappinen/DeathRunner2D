using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForTesting : MonoBehaviour {

    Rigidbody2D rd2d;
    bool isGrounded = true;

    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpPower;

	void Start ()
    {
        speed = 20;
        jumpPower = 250;
        rd2d = GetComponent<Rigidbody2D>();	
	}

	void Update ()
    {
        if (Input.GetKey("space") && isGrounded)
        {
            rd2d.AddForce(transform.up * jumpPower);
        }
        else if(Input.GetKey("left"))
        {
            rd2d.AddForce(transform.right * speed * -1);
        }
        else if(Input.GetKey("right"))
        {
            rd2d.AddForce(transform.right * speed);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }
}
