using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBA : BasicAttackAbility
{
    private float damageValue = 0;
    private ElementType type = ElementType.Physical;

    protected override void DealDamage(Character user, List<Character> other)
    {
        CalculateDamage();
        foreach(Character c in other)
        {
            Combat.DealDamageOfType(c, ElementType.Physical, damageValue);
        }
    }

    private void CalculateDamage()
    {
        //turbo obliczenia
        damageValue = 25f;
    }

}
