using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHandler : MonoBehaviour
{
    public  int slot { get; set; }
    public  Item[] itemMap { get; set; }

    public  Item currentItem => itemMap[slot];

    public  void Pickup(int item) => itemMap[item].SetEnabled(true);

    public  void Drop(int item) => itemMap[item].SetEnabled(false);

    public  void NextSlot() => slot = (slot + 1) % itemMap.Length;

    public  void PreviousSlot() => slot = (slot - 1) % itemMap.Length;

    public  void Use() => currentItem.Use();

    public  void SetSlot(int target) => slot = target;
}
