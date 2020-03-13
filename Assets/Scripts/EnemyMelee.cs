using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{

    float nextAttackTime = 0f;
    public int attackDamage = 1;
    public float attackRate = 1f;
    public Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit the Player");
            if (!Player.playerInvincible)
            {
                player.TakeDamage(attackDamage);
                player.invincibleTimer = 0.5f;
                Player.playerInvincible = true;
            }
        }
    }
}

