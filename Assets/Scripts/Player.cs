using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public static bool playerInvincible;
    public HealthBar healthBar;
    public float invincibleTimer;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        healthBar = FindObjectOfType<HealthBar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        playerInvincible = false;
        invincibleTimer = 0f;
    }

    void Update()
    {
        if (playerInvincible && invincibleTimer > 0f)
        {
            invincibleTimer -= Time.deltaTime;
        }
        else if (invincibleTimer <= 0f)
        {
            playerInvincible = false;
        }

        if (currentHealth <= 0)
        {
            Death();
        }
    }


    public void HealingPotion()
    {
        healthBar.SetHealth(currentHealth);
    }


    public void TakeDamage(int damage)
    {
        if (!playerInvincible)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
            playerInvincible = true;
            invincibleTimer = 1f;
        }
    }

    void Death()
    {
        Destroy(player);
    }
}
