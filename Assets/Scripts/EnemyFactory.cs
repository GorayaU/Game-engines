using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyFab;

    private void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        int randomSpawnX = Random.Range(-5, 6);
        
        Vector3 spawnPos =  new Vector3(randomSpawnX, 1, 0);
        GameObject enemy = Instantiate(enemyFab, spawnPos, Quaternion.identity);

        if (enemy.GetComponent<Enemy>() != null)
        {
            enemy.GetComponent<Enemy>().factory = this;
        }
    }
}
