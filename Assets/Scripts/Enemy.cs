using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    public GameObject CritTextPrefab;
    [SerializeField]
    private int maxHealth = 10;
    public int currentHealth;

    public bool enemyInvincible;
    public float invincibleTimer;
    public int critChance;
    public int crit;

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

        Debug.Log(enemyInvincible);
    }

    public void TakeDamage(int attackDamage)
    {
        currentHealth -= attackDamage;

        if (currentHealth <= 0)
        {
            Death();
        }

    }

    void Death()
    {
        Debug.Log("Enemy Died!");
        Destroy(gameObject);
    }


    public int TransferEnemyHP()
    {
        return currentHealth;
    }


    /*
    void ShowCritText()
    {
        Debug.Log("CritText");
        var Go = Instantiate(CritTextPrefab, transform.position, Quaternion.identity, transform);
        Go.GetComponent<TextMesh>().text = currentHealth.ToString();
    }
    void ShowFloatingText()
    {
        Debug.Log("Floating Text");
        var go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = currentHealth.ToString();
    }
    */

}
