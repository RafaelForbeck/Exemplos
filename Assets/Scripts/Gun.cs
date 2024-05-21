using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float shotInterval;
    public GameObject shotModel;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= shotInterval)
        {
            Fire();
            timer = 0f;
        }
    }

    void Fire()
    {
        Instantiate(shotModel, transform.position, transform.rotation);
    }
}
