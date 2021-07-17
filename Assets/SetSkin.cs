using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Renderer rend = GetComponent<Renderer>();
 if (rend != null){
     
switch (SkinsScript.Skin)
      {
          case "1":
            rend.material = Resources.Load<Material>("1");
            Debug.Log("1");
              break;
          case "2":
            rend.material = Resources.Load<Material>("2");
            Debug.Log("2");
              break;
          case "3":
            rend.material = Resources.Load<Material>("3");
            Debug.Log("3");
              break;
          case "4":
            rend.material = Resources.Load<Material>("4");
            Debug.Log("3");
              break;
          case "5":
            rend.material = Resources.Load<Material>("5");
            Debug.Log("3");
              break;
          case "6":
            rend.material = Resources.Load<Material>("6");
            //Debug.Log("3");
              break;
          case "7":
            rend.material = Resources.Load<Material>("7");
            //Debug.Log("3");
              break;
          case "8":
            rend.material = Resources.Load<Material>("8");
            //Debug.Log("3");
              break;
          case "9":
            rend.material = Resources.Load<Material>("9");
            //Debug.Log("3");
              break;
          
              
          default:
            rend.material = Resources.Load<Material>("1");
              break;
      }

     
 }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
