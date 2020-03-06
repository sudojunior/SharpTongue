using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{
    //Thanks to Harry Donovan for help with fixing this script
    public Camera cam;


    [SerializeField] 
    private float radius;
    private Transform pivot;

    void Start()
    {
        pivot = transform.parent;
    }

    void FixedUpdate()
    {
        Vector3 fpVector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        fpVector -= pivot.transform.position;
        float angle = Mathf.Atan2(fpVector.y, fpVector.x) * Mathf.Rad2Deg;
        pivot.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
