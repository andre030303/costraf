using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public float speed;
    public float rotation;
    Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        //Vector3 dvig = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        //transform.Translate(dvig * speed * Time.deltaTime);
        //Rb.MovePosition(transform.position + dvig * Time.deltaTime * speed);   
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
            Rb.AddRelativeForce(Vector2.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddRelativeForce(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            //transform.Rotate(0, 0, rotation);
            //Vector3 rot = new Vector3(0,0,1);
            //Quaternion rot1 = Quaternion.Euler(rot * (Time.fixedDeltaTime + speed));
            Rb.MoveRotation(Rb.rotation + speed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            //transform.Rotate(0, 0, rotation - rotation*2);
            //Vector3 rot = new Vector3(0, 0, -1);
            //Quaternion rot1 = Quaternion.Euler(rot * (Time.fixedDeltaTime + speed));
            Rb.MoveRotation(Rb.rotation - speed);
        }
    }
}

