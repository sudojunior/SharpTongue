using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialBulletController : MonoBehaviour
{

    [Header("Projectile Settings")]
    public int numberOfProjectiles;         // Number of projectiles to shoot.
    public float projectileSpeed;           // Speed of the projectile.
    public GameObject ProjectilePrefab;     // Prefab to spawn.

    [Header("Private Variables")]
    private Vector2 startPoint;             // Starting position of the bullet.
    private const float radius = 1;         // Help us find the move direction.
    private float attackTime = 1f;


    void Update()
    {
        Debug.Log("Player Detected: " + PlayerDetect.detectedPlayer);
        attackTime -= Time.deltaTime;
        if (PlayerDetect.detectedPlayer == true)
        {
            if (attackTime <= 0)
            {
                RadialProjectileAttack();
            }
        }
    }

    public void RadialProjectileAttack()
    {
        attackTime = 0.5f;
        startPoint = gameObject.transform.position;
        SpawnProjectile(numberOfProjectiles);
    }

    // Spawns x number of projectiles
    private void SpawnProjectile(int _numberOfProjectiles)
    {
        float angleStep = 360f / _numberOfProjectiles;
        float angle = 0f;

        for (int i = 0; i <= _numberOfProjectiles -1 ; i++)
        {
            // Direction Calculations
            float projectileDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI) / 180) * radius;
            float projectileDirYPosition = startPoint.y + Mathf.Cos((angle * Mathf.PI) / 180) * radius;

            Vector2 projectileVector = new Vector2(projectileDirXPosition, projectileDirYPosition);
            Vector2 projectileMoveDirection = (projectileVector - startPoint).normalized * projectileSpeed;

            GameObject tempObj = Instantiate(ProjectilePrefab, startPoint, Quaternion.identity);
            tempObj.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileMoveDirection.x, projectileMoveDirection.y);

            angle += angleStep;
        }
    }

    void AttackTimer()
    {
        RadialProjectileAttack();
    }
}
