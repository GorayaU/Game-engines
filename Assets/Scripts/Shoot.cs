// Shoot.cs
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            if (bullet.TryGetComponent<Rigidbody>(out var rb))
            {
                rb.linearVelocity = transform.forward * bulletSpeed;
            }

            GameEvents.BulletFired();
        }
    }
}