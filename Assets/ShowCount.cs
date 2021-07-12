using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCount : MonoBehaviour
{

     public Slider sliderval;
     public TextMeshProUGUI change;
 public float slidervalint;
    public static float PlatformsCount;


    void Start()
    {

    }

    void Update()
    {
        
        change.text = "" + sliderval.value;
        PlatformsCount = sliderval.value;
        
    }
}
