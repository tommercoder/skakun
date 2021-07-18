using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SkinsScript : MonoBehaviour
{


    
    /*private bool buyDone2 = false;
    private bool buyDone3 = false;
    private bool buyDone4 = false;
    private bool buyDone5 = false;
    private bool buyDone6 = false;
    private bool buyDone7 = false;
    private bool buyDone8 = false;
    private bool buyDone9 = false;*/

    public static string Skin = "Standart";
    public void ball_1(){
        Skin = "1";
    }

    public void ball_2(){
        if(PlayerPrefs.GetInt("buyDone2") == 0){
        
        
        if(BobusScript.getBonuses() >= 10){
            Skin = "2";
            BobusScript.setBonuses(10);
            p2.enabled = false;
            PlayerPrefs.SetInt("buyDone2", 1);   
            
        }
        
        }
        Debug.Log("" + PlayerPrefs.GetInt("buyDone2")); 
    }
public void ball_3(){
     if(PlayerPrefs.GetInt("buyDone3") == 0){
        if(BobusScript.getBonuses() >= 20){
            Skin = "3";
            p3.enabled = false;
            BobusScript.setBonuses(20);
            
        }
        }
    }
public void ball_4(){
     if(PlayerPrefs.GetInt("buyDone4") == 0){

        if(BobusScript.getBonuses() >= 40){
            Skin = "4";
            p4.enabled = false;
            BobusScript.setBonuses(40);
        }
        }
    }
public void ball_5(){
      if(PlayerPrefs.GetInt("buyDone5") == 0){
        if(BobusScript.getBonuses() >= 40){
            Skin = "5";
            p5.enabled = false;
            BobusScript.setBonuses(40);
        }
        }
    }
public void ball_6(){
      if(PlayerPrefs.GetInt("buyDone6") == 0){
        if(BobusScript.getBonuses() >= 40){
            Skin = "6";
            p6.enabled = false;
            BobusScript.setBonuses(40);
        }
        
        }
    }
public void ball_7(){
      if(PlayerPrefs.GetInt("buyDone7") == 0){

        if(BobusScript.getBonuses() >= 50){
            Skin = "7";
            p7.enabled = false;
            BobusScript.setBonuses(50);
        }
        }
    }
public void ball_8(){
     if(PlayerPrefs.GetInt("buyDone8") == 0){
         
        if(BobusScript.getBonuses() >= 60){
            Skin = "8";
            p8.enabled = false;
            BobusScript.setBonuses(60);
        }
        }
    }
public void ball_9(){

if(PlayerPrefs.GetInt("buyDone9") == 0){
        if(BobusScript.getBonuses() >= 100){
            p9.enabled = false;
            Skin = "9";
            BobusScript.setBonuses(100);
            //PlayerPrefs.SetInt("buyDone9", 1);    
        }
        
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



    private int l;    
 void Awake(){
    l = PlayerPrefs.GetInt("l", 0);
 } 
    // Start is called before the first frame update
    void Start()
    {
        
        if(l != 1){
        PlayerPrefs.SetInt("buyDone2", 0);
        PlayerPrefs.SetInt("buyDone3", 0);
        PlayerPrefs.SetInt("buyDone4", 0);
        PlayerPrefs.SetInt("buyDone5", 0);
        PlayerPrefs.SetInt("buyDone6", 0);
        PlayerPrefs.SetInt("buyDone7", 0);
        PlayerPrefs.SetInt("buyDone8", 0);
        PlayerPrefs.SetInt("buyDone9", 0);

        l = 1;
        PlayerPrefs.SetInt("l", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
