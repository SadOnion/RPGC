using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementType
{
    Physical,
    Fire,
    Nature,
    Wind,
    Water
}

public abstract class BasicAttackAbility : Ability
{
    protected ElementType elementType;

    public override void Use(Character user, List<Character> other)
    {
        DealDamage(user, other);
    }
    public override void Use(Character user, Character other)
    {
        Use(user,new List<Character>(){ other});
    }

    protected abstract void DealDamage(Character user, List<Character> other);
}
