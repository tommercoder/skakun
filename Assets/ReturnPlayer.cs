using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPlayer : MonoBehaviour
{

    public Transform boy;
    public Transform panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 vecPlayer = boy.transform.position;
    Vector3 vecPanel = panel.transform.position;
    
        if(vecPlayer.y < vecPanel.y){
            boy.transform.position = vecPanel;
        }
    }
}
