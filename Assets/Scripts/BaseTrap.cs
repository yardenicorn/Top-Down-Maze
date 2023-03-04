using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseTrap : MonoBehaviour, IDamagable
{
    public LayerMask whatIDamage;
    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(int howMuch)
    {
        throw new System.NotImplementedException();
    }
}
