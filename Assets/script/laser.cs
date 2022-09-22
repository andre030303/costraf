using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distanse;
    public int damage;
    public LayerMask whatIsSolid;
    private float t=0;
    

    private void Update()
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
        transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
}
