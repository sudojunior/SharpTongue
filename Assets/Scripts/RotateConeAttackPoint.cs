using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateConeAttackPoint : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -180f;
        rb.rotation = angle;
    }
}
