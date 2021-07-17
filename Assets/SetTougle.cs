using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTougle : MonoBehaviour
{

    public static bool Collision = true;
    public GameObject toggler;
    void Update()
    {
        if(toggler.GetComponent<Toggle>().isOn){
            Collision = true;
            
        }
        else{
            
            Collision = false;
        }
    }
}
