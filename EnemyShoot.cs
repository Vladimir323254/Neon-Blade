using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float detectionRange;
    [SerializeField] private float fireRate;
    [SerializeField] private float nextFireTime;
    [SerializeField] private Transform EnemyfirePoint;
    [SerializeField] private Animator anim;
    public GameObject bulletPrefab;
    private Transform player;

    void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
        if (Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
        
            

        
            if (Time.time >= nextFireTime)
            {
                anim.SetBool("isAttack", true);
                Invoke("Shoot", 0.7f);
               


                nextFireTime = Time.time + fireRate;
            }
            
        }
        
    }
    public void Shoot()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, EnemyfirePoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(direction * bulletSpeed, ForceMode2D.Impulse);
        anim.SetBool("isAttack", false);
    }
}
