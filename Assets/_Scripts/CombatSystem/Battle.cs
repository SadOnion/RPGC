using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle
{
    private Player player;
    private List<Enemy> enemies;
    public Battle(Player player, List<Enemy> enemies)
    {
        this.enemies = new List<Enemy>();
        this.player=player;
        this.enemies=enemies;
    }

    public void StartBattle()
    {
        int counter =0;
        while(player.health.Value > 0 && enemies.Count > 0)
        {
            Debug.Log("round"+counter);
            enemies[0].health.Value -= player.character.Strength.Value;
             Debug.Log($"Player attacks enemy for {player.character.Strength.Value} Enemy hp:{enemies[0].health.Value}");
             if(enemies[0].health.Value <=0){
                Debug.Log("Player Won");
             enemies.RemoveAt(0);
                return;
            }
            player.health.Value -= enemies[0].character.Strength.Value;
             Debug.Log($"Enemy attacks player for {enemies[0].character.Strength.Value} Player hp:{player.health.Value}");

           if(player.health.Value <=0)
            {
                Debug.Log("Enemy won");
            }
           counter++;
        }
    }
    
}
