using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int health;

    public int MaxHelth;

    private int MaxHelth2;

    private int MaxHelth3;

    private float procenti;

    public HEALTH HEALTH;

    public lvel lvel;

    void Start()
    {
        MaxHelth3=MaxHelth;
        lvel = GetComponent<lvel>();
    }

    public void upgrat(int levl)
    {
        MaxHelth=MaxHelth3+levl;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Scrap")
        {
            Destroy (collision.gameObject);
            lvel.lvelup();
        }
    }

    private void Update()
    {
        if (MaxHelth > MaxHelth2 && MaxHelth < MaxHelth2)
        {
            HEALTH.SetMaxHelth (MaxHelth);
            health=MaxHelth;
            MaxHelth2 = MaxHelth;
        }
        if (health <= 0)
        {
            Destroy (gameObject);
            SceneManager.LoadScene(0);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        HEALTH.SetHealth (health);
        procenti = (float)health/((float)MaxHelth/100);
        GetComponent<wasd>().harm(procenti);
    }
}
