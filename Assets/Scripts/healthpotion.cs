using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpotion : MonoBehaviour
{
    public int playerHealth;

    void Update()
    {
        playerHealth = GameObject.Find("GameManager").GetComponent<Player>().currentHealth;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (playerHealth >= 5)
            {
                GameObject.Find("GameManager").GetComponent<Player>().currentHealth = 10;
                GameObject.Find("GameManager").GetComponent<Player>().HealingPotion();
                Destroy(gameObject);
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<Player>().currentHealth += 5;
                GameObject.Find("GameManager").GetComponent<Player>().HealingPotion();
                Destroy(gameObject);
            }
            
        }

        else
        {
            //Do nothing
        }
        
    }
}
