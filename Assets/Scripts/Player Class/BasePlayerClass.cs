using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass
{
    private string characterClassName;
    private string characterClassDescription;

    private int agility;
    private int endurance;
    private int strength;
    private int intelligence;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }
    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }
    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }
    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    public void Escape()
    {
        //Ability to escape a fight
    }

    public virtual void NormalAttack()
    {
        //Basic Fighting Ability called punching
    }
}
