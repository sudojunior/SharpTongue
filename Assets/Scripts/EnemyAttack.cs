using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public Player player;

    public int attackDamage = 1;

    public float attackRate = 1f;
    float nextAttackTime = 0f;


    void Start()
    {
        player = FindObjectOfType<Player>();
    }


    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit the Player");
            if (Time.time >= nextAttackTime && !Player.playerInvincible)
            {
                player.TakeDamage(attackDamage);
                nextAttackTime = Time.time + 1f / attackRate;
                player.invincibleTimer = 0.5f;
                Player.playerInvincible = true;
            }

            
        }
    }
}
