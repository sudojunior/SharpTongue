using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    float playerHealth;
    public int maxHP;

    private void Start()
    {
        if (playerHealth == 0)
        {
            playerHealth = 1f;
        }
    }

    private void Update()
    {
        // if hit
        if (playerHealth > 0)
        {
            playerHealth -= 0.01f;
            healthBar.SetHealth(playerHealth);
        }
        // else dead
        // send over current health and display (current health/ maxhp)
    }
}
