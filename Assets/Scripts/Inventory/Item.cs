using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool Enabled = false;
    // In seconds
    public float CooldownTime;

    public void SetEnabled(bool value) => Enabled = value;

    public bool CanUse() => Enabled;

    public void Use()
    {
        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown()
    {
        SetEnabled(false);
        yield return new WaitForSeconds(CooldownTime);
        SetEnabled(true);
    }
}

public enum ItemEffect
{
    Heal,
    Speed,
    Strength,
    Reach,
    Haste
}