using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SkillDatabase
{
     public  static List<Skill> Skills;

    public static void CreateSkillList()
    {
        Skills = new List<Skill>()
        {
            new Skill(3,"Warrior Passive","Extra melle","Warrior",
            new Dictionary<string, double>
            {
                {"DamageMulti", 1.20 },
            }),
            new Skill(1,"Hunter Passive","Does Melee Damage","Hunter",
            new Dictionary<string, double>
            {
                {"PetMulti", 1.20 },
            }),
            new Skill(2,"Rogue Passive","Increased Gem Chance","Rogue",
            new Dictionary<string, double>
            {
                {"GemChanceMulti", 1.20 },
            }),


        };
    }

    public static Skill GetSkill(int id)
    {
        return Skills.Find(skill => skill.id == id);
    }

    public static Skill GetSkill(string SkillName)
    {
        return Skills.Find(skill => skill.Name == SkillName);
    }
}

public class Skill
{
    public int id;
    public string Name;
    public string Desc;
    public string Class;
    //Dictionary <Effect ,value>  - Attack , 10
    public Dictionary<string, double> stats;

    public Skill(int id, string Name, string desc, string Class, Dictionary<string, double> stats)
    {
        this.id = id;
        this.Name = Name;
        this.Desc = desc;
        this.Class = Class;
        this.stats = stats;
    }

}