using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangeAttack : MonoBehaviour
{
    public int attackDamage = 1;

    float attackRate = 1f;
    float nextAttackTime = 0f;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            if (Time.time >= nextAttackTime && !collider.gameObject.GetComponentInParent<Enemy>().enemyInvincible)
            {
                Debug.Log("Shot enemy");
                collider.gameObject.GetComponentInParent<Enemy>().TakeDamage(attackDamage);
                nextAttackTime = Time.time + 1f / attackRate;
                collider.gameObject.GetComponentInParent<Enemy>().invincibleTimer = 0.5f;
                collider.gameObject.GetComponentInParent<Enemy>().enemyInvincible = true;
                Destroy(gameObject);
            }
        }

        else
        {
            Destroy(gameObject, 1.0f);
        }
    }
}
