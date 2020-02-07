using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponVisibilty : MonoBehaviour
{
    
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Animator anim;
    

    public void OnDrawGizmosSelected()
    {
         Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            Collisions();
        }

    }
   

    void Attack()
    {
        anim.SetTrigger("Attack");

    }


    void Collisions()
    {
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitenemies)
        {
            Debug.Log("I touched my enemy :) ");
        }
    }


}   
