using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePoint;
    [SerializeField] public float bullets;
    [SerializeField] public float fireRate;
    public float nextFireTime;


    public void Shoot(float direction)
    {
        if ((bullets > 0) && (Time.time > nextFireTime))
        {
            GameObject currentBullet = Instantiate(bullet, firePoint.position, Quaternion.identity);
            Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();
            bullets -= 1;
            nextFireTime = Time.time + fireRate;
            if (direction >= 0)
                currentBulletVelocity.velocity = new Vector2(fireSpeed * 1, currentBulletVelocity.velocity.y);
            else
                currentBulletVelocity.velocity = new Vector2(fireSpeed * -1, currentBulletVelocity.velocity.y);
        }
    }
    public void GetAmmo()
    {
        bullets += 3;
    }
    
}
