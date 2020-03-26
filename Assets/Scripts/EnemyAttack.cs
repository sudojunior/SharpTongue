using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject enemyMelee;
    public PlayerMovement player;

    public Transform distance;
    public int attackDamage = 1;

    public float attackRate = 1f;
    public float nextAttackTime = 0f;


    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        distance = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        float dist = Vector2.Distance(distance.position, transform.position);

        if (dist <= 2f)
        {
            Attack();
        }
    }

    void Attack()
    {
        if (Time.time >= nextAttackTime)
        {
            nextAttackTime = Time.time + 1f / attackRate;
            GameObject EnemyMeleePrefab = Instantiate(enemyMelee, player.transform.position, player.transform.rotation);
            Destroy(EnemyMeleePrefab, 0.5f);
        }


    }

}
