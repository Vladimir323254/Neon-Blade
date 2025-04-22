using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivmentScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageablePlayer"))
        {
            collision.gameObject.GetComponent<Health>().GetAchive();
            Destroy(gameObject);
        }
        else
        {

        }
    }
      
    private void Update()
    {
            
    }
}
