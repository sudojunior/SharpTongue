using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    public float playerHealth;

    private void Start()
    {
        if (playerHealth == 0)
        {
            playerHealth = 100f;
        }
    }

    private void Update()
    {
        // if hit
        if (playerHealth > 0)
        {
            playerHealth -= 1f;
            healthBar.SetHealth(playerHealth);
        }
        // else dead
    }
}
