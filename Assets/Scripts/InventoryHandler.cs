using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{
    int slot;
    Item[] itemMap;

    Item currentItem
    {
        get => itemMap[slot];
    }

    void Pickup(int item)
    {
        itemMap[item].SetEnabled(true);
    }

    void Drop(int item)
    {
        itemMap[item].SetEnabled(false);
    }

    void NextSlot()
    {
        slot = (slot + 1) % itemMap.Length;
    }

    void PreviousSlot()
    {
        slot = (slot - 1) % itemMap.Length;
    }

    void Use()
    {
        currentItem.GetComponent<Item>().Use();
    }

    Weapon.DamageMatrix DamageMatrix()
    {
        Weapon weaponComponent = currentItem.GetComponent<Weapon>();
        if(weaponComponent != null)
        {
            return weaponComponent.DamageMatrix();
        }
        return null;
    }
}
