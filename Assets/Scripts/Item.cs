using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    bool Enabled;
    int cooldown;

    void SetEnabled(bool value)
    {
        Enabled = value;
    }

    bool CanUse()
    {
        return Enabled;
    }

    void Use()
    {

    }
}
