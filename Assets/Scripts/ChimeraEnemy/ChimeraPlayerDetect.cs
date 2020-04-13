using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimeraPlayerDetect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GetComponent<ChimeraEnemyPatrol>().enabled = false;
            GetComponent<ChimeraEnemyAI>().enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            GetComponent<ChimeraEnemyPatrol>().enabled = true;
            GetComponent<ChimeraEnemyAI>().enabled = false;
        }

    }
}