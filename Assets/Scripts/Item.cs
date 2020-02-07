using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public bool Enabled { get; private set; }
    public float cooldownSeconds { get; private set; }

    public void SetEnabled(bool value)
    {
        Enabled = value;
    }

    public bool CanUse()
    {
        return Enabled;
    }

    public void Use()
    {
        SetEnabled(false); 
        StartCoroutine(Cooldown(cooldownSeconds));
    }

    IEnumerator Cooldown(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SetEnabled(true);

    }

    
}
