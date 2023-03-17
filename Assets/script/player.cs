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

    private float procent;

    private float procenti;

    public HEALTH HEALTH;

    void Start()
    {
        MaxHelth3=MaxHelth;
    }

    public void upgrat(int levl)
    {
        MaxHelth=MaxHelth3*levl;

    }

    private void Update()
    {
        if (MaxHelth > MaxHelth2)
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
        procent = (float)MaxHelth/100;
        procenti = (float)health/procent;
        GetComponent<wasd>().harm(procenti);
    }
}
