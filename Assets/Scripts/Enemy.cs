using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyFactory factory;
    private void OnDestroy()
    {
        factory.SpawnEnemy();
    }
}
