using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public GameObject player;

    public int attackDamage = 1;

    public float attackRate = 1f;
    float nextAttackTime = 0f;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit the Player");
            if (Time.time >= nextAttackTime && !Player.playerInvincible)
            {
                player.GetComponent<Player>().TakeDamage(attackDamage);
                nextAttackTime = Time.time + 1f / attackRate;
                player.GetComponent<Player>().invincibleTimer = 0.5f;
                Player.playerInvincible = true;
            }

            
        }
    }
}
