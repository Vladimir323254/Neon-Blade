using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyMove : MonoBehaviour
{
    public float speed = 2.0f;
    public float moveDistance = 5.0f;
    private bool isMovingRight = true;

    private void Update()
    {
        if (isMovingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= moveDistance)
        {
            isMovingRight = false;
        }
        else if (transform.position.x <= -moveDistance)
        {
            isMovingRight = true;
        }
    }
}
