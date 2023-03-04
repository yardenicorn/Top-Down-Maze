using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleChar : BaseCharacter
{
    PurpleChar character = new();
    public override void Die()
    {
        Destroy(character);
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
        damagable.TakeDamage(3);
    }

}
