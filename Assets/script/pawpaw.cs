using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw : MonoBehaviour
{
    public float offset;
    public GameObject laser;
    private laser laser2;
    public Transform pawpoint;
    private float timepaw;
    public float starttimepaw;
    public int damage;
    private int damage2;

    void Start()
    {
        damage2=damage;
        laser2 = laser.GetComponent<laser>();
    }

    public void upgrat(int levl)
    {
        damage=damage2*levl;

    }

    void Update()
    {
        Vector3 mous = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotz = Mathf.Atan2(mous.y,mous.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0,0,rotz+offset);
        
        if(timepaw<=0)
        {
            if(Input.GetMouseButton(0))
            {
                laser2.Upgredate(damage);
                Instantiate(laser,pawpoint.position,transform.rotation);
                timepaw=starttimepaw;
            }
        }
        else
        {
            timepaw-=Time.deltaTime;
        }
    }
}
