using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Monster : MonoBehaviour
{

    public double MonsterHP;
    public double LootValue;
    public int ImageIndex;
    private System.Random rand;
    public bool isBoss;
    public Text HpText;
    private float GemChance = 0.5f;
    private double GemValue;
    private double xpValue;
    private int type;

    void Start()
    {
        InvokeRepeating("MonsterDOT", 0f, 1.0f);
        GemValue = 1;
        xpValue = Math.Round(MonsterHP * 0.1);
        rand = new System.Random();
        System.Random rnd = new System.Random();
        type = rnd.Next(1, 3);
    }

    void Update()
    {
        if (MonsterHP <= 0)
        {
            MonterKill();
        }

        if (Dmg.attacktype!= 0)
        {
            MonsterDMG();
            Debug.Log("special attack detected");
            HpText.text = "HP = " + Math.Round(MonsterHP);
            return;
        }

        //used for testing with mouse on pc

        if (Input.GetMouseButtonDown(0) || Input.mouseScrollDelta.y > 0)
        {
            MonsterDMG();
            Debug.Log("mouse was pressed");
        }

        foreach (Touch touch in Input.touches)
        {
            if (Input.GetTouch(touch.fingerId).phase == TouchPhase.Ended)
            {
                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    MonsterDMG();
                    Debug.Log(touch.fingerId + " finga was pressed");
                }
            }
        }
        HpText.text = "HP = " + Math.Round(MonsterHP);
    }

    public void MonterKill()
    {
        Money.gold += Math.Round(LootValue - (rand.NextDouble() * (LootValue / 25)));
        LevelingScript.XP += xpValue;
        if (LevelingScript.XP >= LevelingScript.XPToNextLevel)
            LevelingScript.LevelUp();


        System.Random rnd = new System.Random();
        int roll = rnd.Next(1, 3);
        switch (roll)
        {
            case 1:
                Resources.Wheat += 1;
                break;
            case 2:
                Resources.Meat += 1;
                break;
            case 3:
                Resources.Beet += 1;
                break;
            default:
                break;
        }



        if (UnityEngine.Random.Range(0f,1f) < GemChance)
        {
            Money.gems += GemValue;
        }

        // spot for animations baby 
        if (isBoss)
        {
            BossKill();
        }

        Destroy(gameObject);
    }

    void MonsterDOT()
    {
        MonsterHP -= PetStats.DamageOT;
    }

    void MonsterDMG()
    {
        MonsterHP -= Dmg.Calc(type);
    }

    void BossKill()
    {
        //change of stage or something i dunno
        MonsterManager.StageClear();
    }

}
