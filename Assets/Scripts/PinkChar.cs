using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkChar : BaseCharacter
{

    public override void Die()
    {
        throw new System.NotImplementedException();
    }

    public override void SpecialAbility()
    {

    }

    public override void TakeDamage(int howMuch)
    {
        throw new System.NotImplementedException();
    }

    public override void ApplyDamage(IDamagable damagable)
    {
        damagable.TakeDamage(5);
    }
}
