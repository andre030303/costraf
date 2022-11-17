using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D Rb;

    public int health;

    public Transform player;

    public float offset;

    public float rotation;

    public float speed;

    public float stopos;

    private void Awake()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy (gameObject);
        }

        Vector3 Enemy = player.position - transform.position;
        float rotz = (Mathf.Atan2(Enemy.y, Enemy.x) * Mathf.Rad2Deg) + offset;
        if (Rb.rotation > rotz)
        {
            Rb.AddTorque(-rotation);
        }
        if (Rb.rotation < rotz)
        {
            Rb.AddTorque (rotation);
        }
        if (Vector2.Distance(player.position, transform.position) > stopos)
        {
            Rb.AddRelativeForce(Vector2.up * speed);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
