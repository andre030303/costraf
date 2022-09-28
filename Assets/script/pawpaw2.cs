using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw2 : MonoBehaviour
{
    public float offset;
    Rigidbody2D Rb;
    public GameObject laser;
    public Transform pawpoint;
    public Transform player;
    private float timepaw;
    public float starttimepaw;
    public float zader;
    private float timezader;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {    
        Vector3 Enemy =player.position - transform.position;
        float rotz = Mathf.Atan2(Enemy.y,Enemy.x)*Mathf.Rad2Deg;
        if(timezader>=zader)
        {
            transform.rotation=Quaternion.Euler(0,0,rotz+offset); 
            timezader=0;
        }
        timezader+=1;

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
