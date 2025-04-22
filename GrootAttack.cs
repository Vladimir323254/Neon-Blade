using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrootAttack : MonoBehaviour
{
    public float attackRange = 2.0f;
    public float damage = 10.0f;
    public float attackRate = 1.0f;
    [SerializeField] private Animator anim;

    private Transform player;
    private float nextAttackTime = 0.0f;

    private void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("DamageablePlayer").transform;

        
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            
            if (Time.time >= nextAttackTime)
            {
                anim.SetBool("isAttack", true);
                Invoke("animAttack", 0.6f);
                player.GetComponent<Health>().TakeDamage(damage);
                
                nextAttackTime = Time.time + attackRate;
            }
            
        }
    }
    public void animAttack() 
    {
        anim.SetBool("isAttack", false);
    }
}
