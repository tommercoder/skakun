using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobusScript : MonoBehaviour
{

    private static int bonuses = 0;

    public static void addBonuses(){
        BobusScript.bonuses++;
    } 
    public static int getBonuses(){
        return BobusScript.bonuses;
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject WinMenu;
    public GameObject MoveMenu;
     private void OnCollisionEnter(Collision collision)
    {
         if(GetComponent<Collider>().tag == "Bonus"){
            Renderer rend = GetComponent<Renderer>();
            rend.material = Resources.Load<Material>("Red");
            BobusScript.addBonuses();
            if(ObjectSpawner.CountBonuses == 0){
                
                MoveMenu.SetActive(false);
                WinMenu.SetActive(true);

            }
            
            ObjectSpawner.CountBonuses--;

        }
           
    }
}
     



