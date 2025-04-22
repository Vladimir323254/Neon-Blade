using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grootmovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float detectionRange = 10.0f;
    [SerializeField] private Animator anim;

    private Transform player;
    private bool isFollowing = false;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
        if (Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
            isFollowing = true;
        }
        else
        {
            isFollowing = false;
        }

        
        if (isFollowing)
        {
            transform.position += Vector3.Normalize(player.position - transform.position) * moveSpeed * Time.deltaTime;
            anim.SetFloat("Velocity", 1);
        }
        else
            anim.SetFloat("Velocity", 0);
    }
}
