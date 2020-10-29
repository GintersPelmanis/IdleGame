using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSkills : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SkillDatabase.CreateSkillList();
        if(PlayerStats.PlayerSkills == null)
        {
            PlayerStats.PlayerSkills = new List<Skill>();
        }
    }


}
