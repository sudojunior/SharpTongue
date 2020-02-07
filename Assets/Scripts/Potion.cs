using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    public ItemEffect effect { get; }
    public float amount { get; }
    public float duration { get; }
}
