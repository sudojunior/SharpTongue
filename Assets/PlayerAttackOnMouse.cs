using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackOnMouse : MonoBehaviour
{
    public GameObject attackPrefab;
    public GameObject rangedAttackPrefab;
    public GameObject player;
    public Transform firePoint;
    public Camera cam;
    public Vector3 point = new Vector3();
    public Vector2 mousePos = new Vector2();
    public Rigidbody2D rb;
    public float boltSpeed = 20f;


    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rangedAttack();
        }
    }
    void Attack()
    {
        GameObject attackObj = Instantiate(attackPrefab, firePoint.position, firePoint.rotation);
        Destroy(attackObj, 1.0f);
    }

    
    void rangedAttack()
    {
        Vector3 point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y));
        Debug.Log(point);
        GameObject attackObj = Instantiate(rangedAttackPrefab, firePoint.position, firePoint.rotation);

        rb = attackObj.GetComponent<Rigidbody2D>();
        //Thanks to Matt Shaw for help with this line
        rb.AddForce((firePoint.transform.position - player.transform.position ).normalized * boltSpeed, ForceMode2D.Impulse);
            
    }

}
