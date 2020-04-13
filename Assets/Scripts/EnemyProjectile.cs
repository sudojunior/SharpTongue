using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

    public int attackDamage = 2;
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
                Destroy(gameObject);
            }
        }

        else if (collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("EnemyLVL1") || collider.gameObject.CompareTag("EnemyProjectile"))
        {
            //Do nothing
        }

        else
        {
            Debug.Log("hit: " + gameObject.name);
            Destroy(gameObject);
        }
    }
}

