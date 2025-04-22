using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float damagePerSecond = 1; 
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageablePlayer"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damagePerSecond * Time.deltaTime);
            
        }
        
    }

}
