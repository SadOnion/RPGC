using Kryz.CharacterStats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public Health Health { get; private set; }

    public CharacterStat Strength { get; private set;}
    public CharacterStat Dexterity { get; private set; }
    public CharacterStat Intelligence { get; private set; }
    public CharacterStat Vitality { get; private set; }

    public CharacterStat Armor { get; private set; }
    public CharacterStat FireResist { get; private set; }
    public CharacterStat WaterResist { get; private set; }
    public CharacterStat WindResist { get; private set; }
    public CharacterStat NatureResist { get; private set; }

    public Character(BaseStats baseStats)
    {
        Strength = new CharacterStat(baseStats.Strength);
        Dexterity = new CharacterStat(baseStats.Dexterity);
        Intelligence = new CharacterStat(baseStats.Intelligence);
        Vitality = new CharacterStat(baseStats.Vitality);

        Armor = new CharacterStat(baseStats.Armor);
        FireResist = new CharacterStat(baseStats.FireResist);
        WaterResist = new CharacterStat(baseStats.WaterResist);
        WindResist = new CharacterStat(baseStats.WindResist);
        NatureResist = new CharacterStat(baseStats.NatureResist);

        Health = new Health(Vitality);
    }
    public CharacterStat GetStat(StatAribute statAribute)
    {
        switch (statAribute)
        {
            case StatAribute.Str:
                return Strength;
            case StatAribute.Dex:
                return Dexterity;
            case StatAribute.Int:
                return Intelligence;
            case StatAribute.Vit:
                return Vitality;
            case StatAribute.Armor:
                return Armor;
            case StatAribute.FireRes:
                return FireResist;
            case StatAribute.NatureRes:
                return NatureResist;
            case StatAribute.WaterRes:
                return WaterResist;
            case StatAribute.WindRes:
                return WindResist;
            default:
                return null;
        }
    }
}
