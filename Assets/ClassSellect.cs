using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSellect : MonoBehaviour
{

    public string ClassName;
    public int StarterId;
    public string ClassDesc;
    public void SelectClass()
    {
        PlayerStats.ClassName = ClassName;
        PlayerStats.GiveSkill(StarterId);
        PlayerStats.ClassDesc = ClassDesc;

        Debug.Log(PlayerStats.ClassName);
        Debug.Log(PlayerStats.ClassDesc);
    }
}
