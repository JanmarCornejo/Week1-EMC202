using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerClass
{
    //Attributes

    public Transform attackPoint;
    public float Range = 0.5f;
    public LayerMask enemyLayer;


    //Class Name & Description

    private string characterClassName;
    private string characterClassDescription;


    //STATS

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


    //BASE FEATURES

    public void Escape()
    {
        //Ability to escape a fight
    }

    public virtual void NormalAttack()
    {
        //Basic Fighting Ability called punching
        Collider2D[]hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, Range, enemyLayer);

        foreach(Collider2D enemy in hitEnemies)
        {
            //Enemy Damaged
        }
    }

    public void Guard()
    {
        //Ability to defend oneself

    }
}
