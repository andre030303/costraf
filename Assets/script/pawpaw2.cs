using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw2 : MonoBehaviour
{
    public float offset;
    public float rotation;
    Rigidbody2D Rb;
    public GameObject laser;
    public Transform pawpoint;
    public Transform player;
    private float timepaw;
    public float starttimepaw;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {    
        Vector3 Enemy = player.position - transform.position;
        float rotz = (Mathf.Atan2(Enemy.y,Enemy.x)*Mathf.Rad2Deg)+offset;
        print(rotz);
        if (Rb.rotation>rotz)
        {
            Rb.AddTorque(-rotation);
        }
        if (Rb.rotation<rotz)
        {   
            Rb.AddTorque(rotation);
        }            
        if(timepaw<=0)
        {
                Instantiate(laser,pawpoint.position,transform.rotation);
                timepaw=starttimepaw;
        }
        else
        {
            timepaw-=Time.deltaTime;
        }
    }
}
