using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    public float speed = 5f; 
    public float distance = 10f; 

    private float currentDistance = 0f; 
    private bool movingForward = true; 

    private Vector3 initialPosition; 

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (movingForward)
        {
           
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            currentDistance += speed * Time.deltaTime;

            if (currentDistance >= distance)
            {
                currentDistance = distance;
                movingForward = false;
            }
        }
        else
        {
          
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            currentDistance -= speed * Time.deltaTime;

            if (currentDistance <= 0f)
            {
                currentDistance = 0f;
                movingForward = true;
            }
        }
    }
}