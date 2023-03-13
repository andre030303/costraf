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

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Boss)
        {
            helbar = GameObject.FindGameObjectWithTag("hp");
            helbar.SetActive(false);
            if(GameObject.Find("Boss") ==  null)
            {
                helbar2 = GameObject.FindGameObjectWithTag("hp2");
                helbar2.SetActive(false);
            }
        }else if (!Boss2)
        {

            helbar = GameObject.FindGameObjectWithTag("hp");
            helbar.SetActive(false);
            helbar2 = GameObject.FindGameObjectWithTag("hp2");
            helbar2.SetActive(false);  
        }
        if (Boss2)
        {
            helbar2 = GameObject.FindGameObjectWithTag("hp2");
            helbar2.SetActive(false);
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
        if(Boss2 == true)
        {   
            helbar2.SetActive(true);
            HEALTH = helbar2.GetComponent<HEALTH>();
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
            if(Boss2 == true)
            {
                helbar2.SetActive(false);             
            }
            Destroy (gameObject);
        }

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
        if(Boss == true || Boss2 == true)
        {
            HEALTH.SetHealth (healt);
        }
    }
}
