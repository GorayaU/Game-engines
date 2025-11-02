// Enemy.cs
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Die()
    {
        GameEvents.EnemyKilled(transform.position);
        Destroy(gameObject);
    }
}