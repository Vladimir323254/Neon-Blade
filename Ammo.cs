using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageablePlayer"))
        {
            collision.gameObject.GetComponent<Shooter>().GetAmmo();
            Destroy(gameObject);
        }   
        else
        {

        }
    }
}
