using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    public GameObject CritTextPrefab;
    [SerializeField]
    private int maxHealth = 10;
    private int currentHealth;
   

    public static bool enemyInvincible { get; set; }
    public float invincibleTimer;
    public int critChance;
    public int crit;

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


        crit = Random.Range(0, 100);

        if (CritTextPrefab && crit % critChance  == 0 )
        {
            currentHealth -= (damage * 2);
            ShowCritText();
        }

        // If crit when divided by "critChance", whatever critChance may be - pass in a value - then if the answer has no remainder the critical hit will occur

        else
        {
            currentHealth -= damage;
        }
        if (FloatingTextPrefab && currentHealth > 0)
        {
            ShowFloatingText();
        }

        

        if (currentHealth <= 0)
        {
            Death();
        }


    }

    void ShowCritText()
    {
        var Go = Instantiate(CritTextPrefab, transform.position, Quaternion.identity, transform);
        Go.GetComponent<TextMesh>().text = currentHealth.ToString();
    }
    void ShowFloatingText()
    {

        var go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = currentHealth.ToString();

        
    }

    void Death()
    {
        Debug.Log("Enemy Died!");
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
