using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public float speed;
    public float rotation;
    Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            Rb.AddRelativeForce(Vector2.up * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Rb.AddRelativeForce(Vector2.down * speed);
        }
        
        /*if (Input.GetKey(KeyCode.A))
        {
            Rb.AddRelativeForce(Vector2.left * speed);
        }


        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddRelativeForce(Vector2.right * speed);
        }*/

        if (Input.GetKey(KeyCode.Q))
        {
            Rb.AddTorque(rotation);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Rb.AddTorque(-rotation);
        }
    }
}

