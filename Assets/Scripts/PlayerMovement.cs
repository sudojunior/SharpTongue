using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    [SerializeField]
    private Transform attackPoint;

    Vector2 Movement;


    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);

        Vector3 lookPos = Vector3.zero;


        if (Movement.x == 1)
        {
            lookPos.y = 0;
        }
        else if (Movement.x == -1)
        {
            lookPos.y = 180;
        }

        if (Movement.y == 1)
        {
            lookPos.z = 90;
        }
        else if (Movement.y == -1)
        {
            lookPos.z = -90;
        }
        else
        {
            lookPos.z = 0;
        }

        attackPoint.rotation = Quaternion.Euler(lookPos);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
