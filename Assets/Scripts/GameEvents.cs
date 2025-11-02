// GameEvents.cs
using System;
using UnityEngine;

public static class GameEvents
{
    public static event Action OnBulletFired;
    public static event Action<Vector3> OnEnemyKilled;

    public static void BulletFired() => OnBulletFired?.Invoke();
    public static void EnemyKilled(Vector3 pos) => OnEnemyKilled?.Invoke(pos);
}