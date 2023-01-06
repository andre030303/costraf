using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelrf : MonoBehaviour
{
    public float offset;

    public Transform enemy;

    public float rotation;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") != null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        }
        if (enemy != null)
        {
            Vector3 Enemy = enemy.position - transform.position;
            float rotz = (Mathf.Atan2(Enemy.y, Enemy.x) * Mathf.Rad2Deg);
            transform.rotation = Quaternion.Euler(0, 0, rotz + offset); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
