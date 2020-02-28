using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangeAttack : MonoBehaviour
{

    public GameObject enemy;

    public int attackDamage = 1;

    float attackRate = 1f;
    float nextAttackTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            if (Time.time >= nextAttackTime && !Enemy.enemyInvincible)
            {
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
                nextAttackTime = Time.time + 1f / attackRate;
                enemy.GetComponent<Enemy>().invincibleTimer = 0.5f;
                Enemy.enemyInvincible = true;
            }
        }
    }
}
