using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Basic Stats
    public string characterName; //name of character
    public int MaxHealth = 100;
    public int Health;
    public int Strength = 10;
    public int Defense = 10;

    public void Initialize(string name, int maxHealth, int strength, int defense)
    {
        characterName = name;
        MaxHealth = maxHealth;
        Strength = strength;
        Defense = defense;
        Health = MaxHealth;
    }

    void Start()
    {
        Health = MaxHealth; //on start, Health set to MaxHealth
    }
}