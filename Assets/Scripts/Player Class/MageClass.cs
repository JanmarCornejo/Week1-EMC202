using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageClass : BasePlayerClass
{
    public void Magelass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "High Damage, but easily killed";
        Agility = 10;
        Endurance = 6;
        Strength = 8;
        Intelligence = 15;
    }

    public override void NormalAttack()
    {
        base.NormalAttack();
        //Instead of punch, it is a simple magic missle animation
    }
}
