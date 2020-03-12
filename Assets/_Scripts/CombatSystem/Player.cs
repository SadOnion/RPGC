using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] BaseStats stats;
    public Character character;
    public BasicAttackAbility basicAttack;
    void Start()
    {
        character = new Character(stats);
        basicAttack = new ExampleBA();
    }


}
