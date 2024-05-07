using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyModel;

    float interval = 0f;
    float timer = 0;
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            SpawnEnemy();
            interval = Random.Range(0.5f, 3f);
            timer = 0;
        }
    }

    void SpawnEnemy()
    {
        float x = Random.Range(-5f, 5f);
        float y = transform.position.y;

        Vector3 position = new Vector3(x, y, 0);

        Instantiate(enemyModel, position, Quaternion.identity);
    }
}
