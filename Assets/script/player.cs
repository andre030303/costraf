using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
public int health;
public int MaxHelth;
private int MaxHelth2;
public HEALTH helbar;

private void Update()
{
    if(MaxHelth>MaxHelth2)
    {
        helbar.SetMaxHelth(MaxHelth); 
    }
    MaxHelth2 = MaxHelth;
    if (health <= 0)
    {
        Destroy(gameObject);
    }
}

public void TakeDamage(int damage)
{
    health -= damage;
    helbar.SetHealth(health);
}
}
