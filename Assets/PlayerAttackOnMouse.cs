using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackOnMouse : MonoBehaviour
{
    public GameObject attackPrefab;
    public Transform firePoint;

    void Update()
    {
        //Converting camera point to world point

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    void Attack()
    {
        GameObject attackObj = Instantiate(attackPrefab, firePoint.position, firePoint.rotation);
        Destroy(attackObj, 1.0f);
    }

}
