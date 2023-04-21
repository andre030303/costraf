using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawpaw2 : MonoBehaviour
{
    [SerializeField] private float offset;

    [SerializeField] private float rotation;

    Rigidbody2D Rb;

    [SerializeField] private GameObject laser;

    [SerializeField] private Transform pawpoint;

    [SerializeField] private Transform player;

    [SerializeField] private Transform bas;

    private float timepaw;

    [SerializeField] private float starttimepaw;

    [SerializeField] private float ros;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {  
        transform.position = new Vector3(bas.position.x,bas.position.y,0);
        Vector3 Enemy = player.position - transform.position;
        float rotz = (Mathf.Atan2(Enemy.y, Enemy.x) * Mathf.Rad2Deg) + offset;
        if (Rb.rotation > rotz)
        {
            Rb.AddTorque(-rotation);
        }
        if (Rb.rotation < rotz)
        {
            Rb.AddTorque (rotation);
        }
        if ( timepaw <= 0 & ros > Vector2.Distance(player.position, transform.position))
        {
            Instantiate(laser, pawpoint.position, transform.rotation);
            timepaw = starttimepaw;
        }
        else
        {
            timepaw -= Time.deltaTime;
        }
    }
}
