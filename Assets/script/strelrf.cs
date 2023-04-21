using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelrf : MonoBehaviour
{
    [SerializeField] private float offset;

    [SerializeField] private Transform enemy;

    [SerializeField] private float rotation;

    public void Enemy(GameObject i)
    {
        enemy = i.transform;
    }    

    void Update()
    {
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
