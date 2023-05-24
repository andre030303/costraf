using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float zader;

    private float schet;  

    [SerializeField] private float lifetime;

    [SerializeField] private float distanse;

    [SerializeField] private int damage;

    [SerializeField] private LayerMask whatIsSolid;
    
    public void Upgredate(int damage2)
    {
        damage=damage2;
    }

    private void Update()
    {       
        transform.Translate(Vector2.up*speed*Time.deltaTime);
        if(schet>=zader)
        {
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,transform.up,distanse,whatIsSolid);
            if(hitInfo.collider != null)
            {   

                if(hitInfo.collider.CompareTag("Enemy") || hitInfo.collider.CompareTag("Boss"))
                {
                    hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                }
                if (hitInfo.collider.CompareTag("Player"))
                {
                    hitInfo.collider.GetComponent<player>().TakeDamage(damage);
                }
                Destroy(gameObject);
            }

            if(lifetime<=schet)
            {
                Destroy(gameObject);
            }  
        }
        schet+=Time.deltaTime;

    }
}
