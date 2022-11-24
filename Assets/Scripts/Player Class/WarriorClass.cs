using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorClass : BasePlayerClass
{
    public void Warrior()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "Average Warrior, To Deal Enough Damage";
        Agility = 15;
        Endurance = 10;
        Strength = 12;
        Intelligence = 8;
    }
}