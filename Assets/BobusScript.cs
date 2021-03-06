using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobusScript : MonoBehaviour
{

    private static int bonuses = PlayerPrefs.GetInt("Bonuses");

    public static void addBonuses(){
        BobusScript.bonuses++;
        PlayerPrefs.SetInt("Bonuses", BobusScript.bonuses + 100);
    } 
    public static int getBonuses(){
        return PlayerPrefs.GetInt("Bonuses");
    }

    public static void setBonuses(int bon){
        if(bonuses - bon >= 0){
            
            bonuses = BobusScript.getBonuses() - bon; 
            PlayerPrefs.SetInt("Bonuses", BobusScript.bonuses);
        }
        
    }
    // Start is called before the first frame update
    private void Awake()
    {
        canvas = GameObject.Find("Canvas");
        WinMenu = GameObject.Find("Done");
        MoveMenu = GameObject.Find("Moves");
    }
    void Start()
    {
        WinMenu.SetActive(false);
       // MoveMenu = GameObject.FindWithTag("UiControls");
    }

    void Update()
    {
        
    }
    public GameObject canvas;
    public GameObject WinMenu;
    public GameObject MoveMenu;

    /*Resources.Load<Material>("Red")*/    

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Collider>().tag == "Bonus")
        {
            Renderer rend = GetComponent<Renderer>();

        if(rend.material.name == "Yellow (Instance)"){
                rend.material = Resources.Load<Material>("Red");
                BobusScript.addBonuses();
            ObjectSpawner.CountBonuses--;
            if (ObjectSpawner.CountBonuses == 0)
            {
                MoveMenu.SetActive(false);
                WinMenu.SetActive(true);
            }
            }
        }
    }
}
     



