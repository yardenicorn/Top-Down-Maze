using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTrap : MonoBehaviour
{
    public LayerMask whatIDamage;
    void ApplyDamage(IDamagable damagable)
    {

    }

    public abstract void StepOnTrap();
}
