using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimeraBullet : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveSpeed;
    private int damage = 2;

    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            GameObject.FindObjectOfType<Player>().TakeDamage(damage);
        }
        else if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("EnemyLVL1") || other.gameObject.CompareTag("EnemyProjectile"))
        {
            //Do nothing
        }
        else if (other.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }


        else
        {
         
        }
    }
}
