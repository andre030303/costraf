using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public float speed;

    private float speed2;

    public float rotation;
    
    Rigidbody2D Rb;

    void Start()
    {
        speed2=speed;
        Rb = GetComponent<Rigidbody2D>();
    }

    public void upgrat(int levl)
    {
        speed=speed2+levl;
    }

    public void harm(float procenti)
    {
        if(procenti< 50)
        {
            speed=(speed/50)*procenti;
            rotation=(rotation/50)*procenti;
        }

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

        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddTorque(rotation);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddTorque(-rotation);
        }
    }
}

