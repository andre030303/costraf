using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distanse;
    public int damage;
    private float zader=0;
    public LayerMask whatIsSolid;
    private float t=0;
    

    private void Update()
    {       
        transform.Translate(Vector2.up*speed*Time.deltaTime);
        if(zader>=2)
        {
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,transform.up,distanse,whatIsSolid);
            if(hitInfo.collider != null)
            {   

                if(hitInfo.collider.CompareTag("Enemy"))
                {
                    hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                }
                Destroy(gameObject);
            }
            t += 1;

            if(lifetime==t)
            {
                Destroy(gameObject);
            }  
        }
        zader+=1;

    }
}
