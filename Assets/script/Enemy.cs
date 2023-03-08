using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D Rb;

    public int healt;

    public Transform player;

    public float offset;

    public float rotation;

    public float speed;

    public float stopos;

    public bool Boss;

    private HEALTH HEALTH;

    private GameObject helbar;

    private void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (GameObject.FindGameObjectWithTag("hp") != null)
        {
            helbar = GameObject.FindGameObjectWithTag("hp");
            helbar.SetActive(false);
        }
    }

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        if(Boss == true)
        {   
            helbar.SetActive(true);
            HEALTH = helbar.GetComponent<HEALTH>();
            HEALTH.SetMaxHelth (healt);
        }
    }

    private void Update()
    {
        if (healt <= 0)
        {
            if(Boss == true)
            {
                helbar.SetActive(false);               
            }
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
        healt -= damage;
        if(Boss == true)
        {
            HEALTH.SetHealth (healt);
        }
    }
}
