using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class PlayerStats
{
    public static double Damage = 1;
    public static string ClassName;
    public static string ClassDesc;
    public static List<Skill> PlayerSkills;
    public static double mana= 100;
    public static double maxmana;
    public static double ManaRegenPs;




    public static void GiveSkill(int id)
    {
        Skill skill = SkillDatabase.GetSkill(id);
        if (skill.Class == ClassName)
        {
            PlayerSkills.Add(skill);
            Debug.Log("Gave Skill" + skill.Name);
        }
           
    }

    public static void GiveSkill(string name)
    {
        Skill skill = SkillDatabase.GetSkill(name);
        if (skill.Class == ClassName)
            PlayerSkills.Add(skill);
    }



    public static Skill GetSkill(int id)
    {
        return PlayerSkills.Find(item => item.id == id);
    }

    public static Skill GetSkill(string ItemName)
    {
        return PlayerSkills.Find(item => item.Name == ItemName);
    }


}


public static class PetStats
{
    public static double DamageOT = 0;
}

public static class Resources
{
    public static double Wheat;
    public static double Meat;
    public static double Beet;

    public static double CollableWheat;
    public static double CollableMeat;
    public static double CollableBeet;

    public static double Wheatph=0;
    public static double Meatph=0;
    public static double Beetph=0;

    public static void BuyFarm(string type)
    {
        switch(type)
        {
            case "Wheat":
                Wheatph += 10;
                break;
            case "Meat":
                Meatph += 10;
                break;
            case "Beet":
                Beetph += 10;
                break;

        }
        Money.gems -= 100;

    }




}

public static class Dmg{


    public static int attacktype = 0;
    public static double DmgMulti;

    public static double Calc(int enemytype)
    {

        //  basically how we will implement item damage, will loop troup inventory and find every item that increases or miltiplies damage 
        // same with skills, except they might add other stuff too
        //   foreach (var item in Inventory.storeditems)

        DmgMulti = attacktype == enemytype ? 1.2: 1;


        double TotalDamage = PlayerStats.Damage * ((Money.prestigue * 0.01) + 1)* DmgMulti;
        attacktype = 0;

        return TotalDamage;
    }
}


