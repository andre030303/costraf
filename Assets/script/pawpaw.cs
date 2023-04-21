using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw : MonoBehaviour
{
    [SerializeField] private float offset;

    [SerializeField] private GameObject laser;

    [SerializeField] private Transform pawpoint;

    private float timepaw;

    [SerializeField] private float starttimepaw;

    [SerializeField] private int damage;

    private int damage2;

    void Start()
    {
        damage2=damage;
    }

    public void upgrat(int levl)
    {
        damage=damage2+levl;
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
                laser.GetComponent<laser>().Upgredate(damage);
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
