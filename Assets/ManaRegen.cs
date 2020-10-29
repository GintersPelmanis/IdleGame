using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaRegen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.mana != PlayerStats.maxmana)
        {
            if (PlayerStats.mana > PlayerStats.maxmana)
            {
                PlayerStats.mana = PlayerStats.maxmana;
                return;
            }
            PlayerStats.mana += PlayerStats.ManaRegenPs * Time.deltaTime;

        }
        
    }
}
