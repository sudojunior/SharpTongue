using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwordPickUp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && !GameManager.pickedUpSword)
        {
            GameManager.pickedUpSword = true;
            Enemy[] enemies;
            enemies = FindObjectsOfType<Enemy>();

            foreach(Enemy em in enemies)
            {
                GameManager.enemyPositions.Add(em.transform.position);
                GameManager.enemyHealth.Add(em.TransferEnemyHP());
            }

            GameManager.playerPosition = FindObjectOfType<PlayerMovement>().transform.position;
            SceneManager.LoadScene("Sharp Tongue Sir Ward Intro");
            
        }

        else if (collider.tag == "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
