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
        public DamageMatrix(float minDamage, float maxDamage)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public float minDamage { get; set; }
        public float maxDamage { get; set; }
        public float rangeDistance { get; set; }
        public float rangeAngle { get; set; }
    }

    public DamageMatrix GetDamageMatrix()
    {
        return new DamageMatrix(minDamage, maxDamage);
    }
}
