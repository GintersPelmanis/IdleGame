using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;

public class GemsPerSec : MonoBehaviour
{

    public static int GemMulti = 5;
    public static int GemPerSec = 0;
    public static double GemMultiPrice = 1;
    void Start()
    {
        InvokeRepeating("GemsPerSecond", 0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeGemPerSec()
    {

        //should reasearch implementing scaling with better math

        if (Money.gems >= GemMultiPrice)
        {
            GemPerSec += 5;
            Money.gems -= GemMultiPrice * GemMultiPrice;

            GemMultiPrice += Math.Round(GemMultiPrice * 0.30);
        }
    }

    public void GemsPerSecond()
    {
        Money.gems += GemPerSec;
    }
}
