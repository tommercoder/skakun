using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SkinsScript : MonoBehaviour
{

    private bool buyDone2 = false;
    private bool buyDone3 = false;
    private bool buyDone4 = false;
    private bool buyDone5 = false;
    private bool buyDone6 = false;
    private bool buyDone7 = false;
    private bool buyDone8 = false;
    private bool buyDone9 = false;

    public static string Skin = "Standart";
    public void ball_1(){
        Skin = "1";
    }

    public void ball_2(){
        if(buyDone2 != true){

        
        if(BobusScript.getBonuses() >= 10){
            Skin = "2";
            BobusScript.setBonuses(10);
            p2.enabled = false;
        }
        buyDone2 = true;
        //winShow.GetComponent<Text>().enabled = false;
        }
    }
public void ball_3(){
     if(buyDone3 != true){
        if(BobusScript.getBonuses() >= 20){
            Skin = "3";
            p3.enabled = false;
            BobusScript.setBonuses(20);
        }buyDone3 = true;}
    }
public void ball_4(){
      if(buyDone4 != true){

        if(BobusScript.getBonuses() >= 40){
            Skin = "4";
            p4.enabled = false;
            BobusScript.setBonuses(40);
        }buyDone4 = true;}
    }
public void ball_5(){
      if(buyDone5 != true){
        if(BobusScript.getBonuses() >= 40){
            Skin = "5";
            p5.enabled = false;
            BobusScript.setBonuses(40);
        }buyDone5 = true;}
    }
public void ball_6(){
      if(buyDone6 != true){
        if(BobusScript.getBonuses() >= 40){
            Skin = "6";
            p6.enabled = false;
            BobusScript.setBonuses(40);
        }
        buyDone6 = true;
        }
    }
public void ball_7(){
      if(buyDone7 != true){

        if(BobusScript.getBonuses() >= 50){
            Skin = "7";
            p7.enabled = false;
            BobusScript.setBonuses(50);
        }buyDone7 = true;}
    }
public void ball_8(){
     if(buyDone8 != true){
         
        if(BobusScript.getBonuses() >= 60){
            Skin = "8";
            p8.enabled = false;
            BobusScript.setBonuses(60);
        }buyDone8 = true;}
    }
public void ball_9(){

if(buyDone9 != true){
        if(BobusScript.getBonuses() >= 100){
            p9.enabled = false;
            Skin = "9";
            BobusScript.setBonuses(100);
        }
        buyDone9 = true;
    }
}


 public void LeavesBall(){
        Skin = "Leaves";
    }

    
    public TextMeshProUGUI p2;
    public TextMeshProUGUI p3;
    public TextMeshProUGUI p4;
    public TextMeshProUGUI p5;
    public TextMeshProUGUI p6;
    public TextMeshProUGUI p7;
    public TextMeshProUGUI p8;
    public TextMeshProUGUI p9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
