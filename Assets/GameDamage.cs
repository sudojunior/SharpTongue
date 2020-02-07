using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDamage : MonoBehaviour
{
    public Animator anim;

    private Transform attackPoint;

    private float playerRange = 0.1f;



    [SerializeField]
    
    private LayerMask enemyLayers;
    private float playerHealth;
    private float enemyDamage;
   

    void Attack()
    {
        anim.SetTrigger("Attack");

    }
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();

        }
    }

    
}
