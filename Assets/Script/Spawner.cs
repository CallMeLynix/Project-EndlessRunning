using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRangeX = 10f;
    public float spawnPosZ = 10f;

    private float spawnTimer = 0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }    void SpawnEnemy()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(spawnPosX, 0f, spawnPosZ);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
