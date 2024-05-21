using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float life;

    public void TakeDamage(float damage)
    {
        life -= damage;

        if (life <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
