using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DamageableEnemy"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("DamageablePlayer"))
        {

        }
        else if (collision.CompareTag("Player"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
