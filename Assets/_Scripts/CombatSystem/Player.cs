using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] BaseStats stats;
    public Character character;
    public Health health;
    void Start()
    {
        character = new Character(stats);
        health = new Health(character.Vitality);
    }


}
