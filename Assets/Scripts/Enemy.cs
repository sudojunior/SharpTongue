using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 10;
    private int currentHealth;

    public static bool enemyInvincible { get; set; }
    public float invincibleTimer;

    // Update is called once per frame
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (enemyInvincible && invincibleTimer >= 0)
        {
            invincibleTimer -= Time.deltaTime;
        }
        else if (invincibleTimer <= 0)
        {
            enemyInvincible = false;
        }
    } 

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Debug.Log("Enemy Died!");
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
