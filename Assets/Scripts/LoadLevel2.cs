using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (GameManager.pickedUpSword == true)
            {
                SceneManager.LoadScene("Level2Callum");
            }
            else
            {
                Debug.Log("You need a weapon to progress to level 2");
            }
        }
    }
}
