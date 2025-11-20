using NUnit.Framework;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
public class SpawnEnemy : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    public float spawnTimer = 0;
    public float spawnCooldown = 5;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(enemyPrefabs.Count);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            spawnTimer = spawnCooldown;
            SpawnMutipleEnemies();
        }
    }

    void SpawnRandomEnemy()
    {
        float xValue = Random.Range(-8.0f, 8.0f);
        float yValue = 5.5f;
        int randomValue = Random.Range(0, enemyPrefabs.Count);
        Instantiate(enemyPrefabs[randomValue], new Vector3(xValue,yValue,0), Quaternion.identity);
    }

    void SpawnMutipleEnemies()
    {
        int enemyCount = 3;
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnRandomEnemy();
        }        
    }
}
