using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDamage : MonoBehaviour
{
    public float Damage;

    public float Health = 100.0f;

    void Update()
    {
        if(Health > 0)
        {
            Health -= 0.1f;
        }

        if (Health <= 0)
        {
            Debug.Log("You Have Died Lol");
        }

    }





}
