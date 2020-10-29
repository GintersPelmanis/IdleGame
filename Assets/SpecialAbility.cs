using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAbility : MonoBehaviour
{
    public int abilitytype;

    public void ButtonAbility()
    {
        if (PlayerStats.mana >= 10)
        {
            Dmg.attacktype = abilitytype;
            PlayerStats.mana -= 10;
        }
    }


}
