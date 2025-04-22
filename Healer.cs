using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageablePlayer"))
        {
            collision.gameObject.GetComponent<Health>().TakeHealer();
            Destroy(gameObject);
        }
        else
        {

        }
    }

}
