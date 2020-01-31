using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;




   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
;       }
        
        
    }
    void Attack()
    {
        anim.SetTrigger("Attack");

        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitenemies)
        {
            Debug.Log("huzzah, I have damaged my enemy ");
        }
    }
    void OnDrawGizmosSelected()
    {
       

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
