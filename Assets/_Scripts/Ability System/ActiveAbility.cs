using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActiveAbility : Ability
{
    public int Cooldown { get; protected set; }
    public int TurnsUntilReady { get; set; }
    public bool Ready { get; set; } = false;

    public override void Use(Character user, List<Character> other)
    {
        if(TurnsUntilReady == 0)
        {
            ActiveAbilityBody();
            TurnsUntilReady = Cooldown;
        }
        TurnsUntilReady--;
    }
    protected abstract void SetupCooldownValue();
    protected abstract void ActiveAbilityBody();
}
