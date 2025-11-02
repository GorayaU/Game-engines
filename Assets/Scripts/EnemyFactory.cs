// EnemyFactory.cs
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private GameObject enemyFab;

    private void OnEnable()
    {
        GameEvents.OnEnemyKilled += HandleEnemyKilled;
    }

    private void OnDisable()
    {
        GameEvents.OnEnemyKilled -= HandleEnemyKilled;
    }

    private void Start()
    {
        SpawnEnemy();
    }

    private void HandleEnemyKilled(Vector3 _)
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        int randomSpawnX = Random.Range(-5, 6);
        int randomSpawny = Random.Range(1, 6);

        Vector3 spawnPos = new Vector3(randomSpawnX, randomSpawny, 0);
        Instantiate(enemyFab, spawnPos, Quaternion.identity);
    }
}