using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GemPriceText : MonoBehaviour
{
    private Text GemText;

    void Start()
    {
        GemText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GemText.text = "" + GemsPerSec.GemMultiPrice;
    }
}
