using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System;
public class Upgrade : MonoBehaviour
{
    public static int DoTMulti = 1;
    public static int DMGMulti = 1 ;
    public static double DoTPrice = 50;
    public static double DMGPrice = 10;


    public void UpgradeDOT()
    {

        //should reasearch implementing scaling with better math
        if (PetStats.DamageOT >= 100)
        {
            DoTMulti = 10;
        }

        if (Money.gold >= DoTPrice * DoTMulti)
        {
            PetStats.DamageOT += 5 * DoTMulti;
            Money.gold -= DoTPrice * DoTMulti;

            DoTPrice += Math.Round(DoTPrice * 0.30);
        }
        
    }    
    
    public void UpgradeDMG()
    {
        if (PlayerStats.Damage >= 100)
        {
            DMGMulti = 10;
        }


        if (Money.gold >= DMGPrice * DMGMulti)
        {
            PlayerStats.Damage += 2 * DMGMulti;
            Money.gold -= DMGPrice;
            
            DMGPrice += Math.Round(DMGPrice * 0.30);
        }
    }


}
