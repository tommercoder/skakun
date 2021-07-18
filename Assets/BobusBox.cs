using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BobusBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoBus.text = "" + BobusScript.getBonuses();
    }

    // Update is called once per frame

    public TextMeshProUGUI BoBus;
    void Update()
    {
        
    }
}
