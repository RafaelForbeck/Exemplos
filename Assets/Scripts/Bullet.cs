using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private float lifeTime = 0f;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        lifeTime += Time.deltaTime;
        if (lifeTime > 5)
        {
            Destroy(gameObject);
        }
    }
}
