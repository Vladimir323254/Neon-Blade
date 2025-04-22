using UnityEngine;

public class DamageDealerEnemy : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageablePlayer"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("DamageableEnemy"))
        {
            
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
