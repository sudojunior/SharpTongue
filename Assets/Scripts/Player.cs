using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public static bool playerInvincible { get; set; }
    public HealthBar healthBar;
    public float invincibleTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (playerInvincible && invincibleTimer >= 0)
        {
            invincibleTimer -= Time.deltaTime;
        }
        else if (invincibleTimer <= 0)
        {
            playerInvincible = false;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
    
}
