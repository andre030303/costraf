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

    public bool Boss;

    public bool Boss2;

    private HEALTH HEALTH;

    public GameObject helbar;

    public GameObject helbar2;

    public GameObject detal;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Rb = GetComponent<Rigidbody2D>();
        if(Boss == true)
        {   
            helbar.SetActive(true);
            helbar.GetComponent<HEALTH>().SetMaxHelth (healt);
        }
        if(Boss2 == true)
        {   
            helbar2.SetActive(true);
            helbar2.GetComponent<HEALTH>().SetMaxHelth (healt);
        }
    }

    private void Update()
    {
        Vector3 Enemy = player.position - transform.position;
        float rotz = (Mathf.Atan2(Enemy.y, Enemy.x) * Mathf.Rad2Deg) + offset;
        if (Rb.rotation > rotz)
        {
            Rb.AddTorque (-rotation);
        }
        if (Rb.rotation < rotz ) 
        {
            Rb.AddTorque(rotation);
        }
        Rb.AddRelativeForce(Vector2.up * speed);
    }

    public void TakeDamage(int damage)
    {
        healt -= damage;
        if (healt <= 0)
        {
            if(Boss == true)
            {
                helbar.SetActive(false);             
            }
            if(Boss2 == true)
            {
                helbar2.SetActive(false);             
            }
            Destroy (gameObject);
            Instantiate(detal,transform.position,transform.rotation);
        }
        if(Boss == true)
        {
          helbar.GetComponent<HEALTH>().SetHealth (healt);  
        }
        if(Boss2 == true)
        {
            helbar2.GetComponent<HEALTH>().SetHealth (healt);
        }
    }
}
