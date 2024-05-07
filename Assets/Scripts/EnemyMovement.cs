using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    private float hSpeed = 1;
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        transform.position += Vector3.right * hSpeed * speed * Time.deltaTime;
        if (hSpeed == 1)
        {
            if (transform.position.x > 5)
            {
                hSpeed = -1;
            }
        } else
        {
            if (transform.position.x < -5)
            {
                hSpeed = 1;
            }
        }
    }
}
