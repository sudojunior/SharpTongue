using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    float rangeAngle;
    float rangeDistance;
    float minDamage;
    float maxDamage;

    public class DamageMatrix
    {
        public DamageMatrix()
        {

        }

        public float minDamage { get; set; }
        public float maxDamage { get; set; }
        public float rangeDistance { get; set; }
        public float rangeAngle { get; set; }
    }

    public DamageMatrix DamageMatrix()
    {
        return new DamageMatrix {
            minDamage = minDamage,
            maxDamage = maxDamage,
        };
    }
}
