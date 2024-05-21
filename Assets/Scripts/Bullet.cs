using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float damage;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var life = collision.GetComponent<Life>();

        if (life != null )
        {
            life.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
