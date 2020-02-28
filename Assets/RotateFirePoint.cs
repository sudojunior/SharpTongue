using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{

    public Camera cam;
    // public Rigidbody2D rotateFirePointrb;
    public Transform firePointRotate;
    Vector2 mousePos;

    [SerializeField] 
    private float radius;
    private Transform pivot;

    void Start()
    {
        pivot = firePointRotate.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    void FixedUpdate()
    {

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        //Vector2 lookDir = mousePos - rotateFirePointrb.position;

        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //rotateFirePointrb.rotation = angle;

        Vector3 fpVector = Camera.main.WorldToScreenPoint(firePointRotate.position);
        fpVector = Input.mousePosition - fpVector;
        float angle = Mathf.Atan2(fpVector.y, fpVector.x) * Mathf.Rad2Deg;

        pivot.position = firePointRotate.position;
        pivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);


    }
}
