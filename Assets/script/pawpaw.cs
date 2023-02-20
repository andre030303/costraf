using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw : MonoBehaviour
{
    public float offset;
    public GameObject laser;
    public Transform pawpoint;
    private float timepaw;
    public float starttimepaw;

    void Update()
    {
        Vector3 mous = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotz = Mathf.Atan2(mous.y,mous.x)*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0,0,rotz+offset);
        
        if(timepaw<=0)
        {
            if(Input.GetMouseButton(0))
            {
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
