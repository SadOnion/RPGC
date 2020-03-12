using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:MonoBehaviour
{
    public Character character;
    [SerializeField]BaseStats stats;
    public Health health;
    private void Start()
    {
        character = new Character(stats);
        health = new Health(character.Vitality);
    }
}
