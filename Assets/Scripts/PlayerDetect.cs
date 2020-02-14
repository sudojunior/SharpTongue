using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GetComponent<EnemyPatrol>().enabled = false;
            GetComponent<EnemyAI>().enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GetComponent<EnemyPatrol>().enabled = true;
            GetComponent<EnemyAI>().enabled = false;
        }

    }
}