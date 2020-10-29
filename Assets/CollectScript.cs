using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CollectionTimer{ 
    public static System.DateTime LastCollect;
}



public class CollectScript : MonoBehaviour
{

    public int CollectableWheat;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CalculateResources",0f,1f);
        
    }

    void CalculateResources()
    {
        CollectableWheat  = ((System.DateTime.UtcNow - CollectionTimer.LastCollect).TotalSeconds * Resources.Wheatph)-1;
    }

    public void CollectResources()
    {
        Resources.Wheat += CollectableWheat;
        CollectionTimer.LastCollect = System.DateTime.UtcNow;
    }


}
