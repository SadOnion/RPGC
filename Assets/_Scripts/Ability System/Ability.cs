using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability
{
    public Sprite icon;
    public abstract void IconSetup();
    public abstract void Use(Character user, List<Character> other);
    public abstract void Use(Character user, Character other);

    public Ability()
    {
        IconSetup();
    }
}
