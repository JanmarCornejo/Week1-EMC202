using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianClass : BasePlayerClass
{
    public int ChanceStun;

    public void WarriorClass()
    {
        CharacterClassName = "Guardian";
        CharacterClassDescription = "Defensive Class that can take multiple hits";
        Agility = 10;
        Endurance = 15;
        Strength = 8;
        Intelligence = 8;
    }

    public override void NormalAttack()
    {
        base.NormalAttack();
        //BashAnEnemyWithShieldInstead
        //Has 0.8% Chance to inflict stun
        ChanceStun = Random.Range(0, 101);
        if(ChanceStun <= 0.8)
        {
            //Inflict Stun
        }
        else
        {
            //normal damage
        }
    }
}
