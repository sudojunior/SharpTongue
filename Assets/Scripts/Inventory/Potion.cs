using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    public ItemEffect effect { get; [SerializeField] private set; }
    public float amount { get; [SerializeField] private set; }
    public float duration { get; [SerializeField] private set; }
}
