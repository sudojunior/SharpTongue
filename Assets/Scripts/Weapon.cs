using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    float rangeAngle;
    float rangeDistance;
    float minDamage;
    float maxDamage;

    object DamageMatrix() => new object();
}
