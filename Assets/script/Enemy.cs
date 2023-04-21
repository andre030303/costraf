using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D Rb;

    [SerializeField] private int healt;

    private Transform player;

    [SerializeField] private float offset;

    [SerializeField] private float rotation;

    [SerializeField] private float speed;

    [SerializeField] private bool Boss;

    [SerializeField] private bool Boss2;

    private HEALTH HEALTH;

    [SerializeField] private GameObject helbar;

    [SerializeField] private GameObject helbar2;

    [SerializeField] private GameObject detal;

    [SerializeField] private GameObject Boom;

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

    void Update()
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
        if (healt < 1)
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
            Instantiate(Boom, transform.position, transform.rotation);
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
