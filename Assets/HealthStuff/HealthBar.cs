using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tarik Sabin - GNU GENERAL PUBLIC LICENSE
public class HealthBar : MonoBehaviour
{
    private Transform bar;

    private void Start()
    {
        bar = transform.Find("Bar");
    }

    public void SetHealth(float healthNormalized)
    {
        bar.localScale = new Vector3(healthNormalized, 1f);
    }
}
