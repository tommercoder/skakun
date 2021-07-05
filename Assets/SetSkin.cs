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
          case "Blue":
            rend.material = Resources.Load<Material>("Blue");
            Debug.Log("Blue");
              break;
          case "Red":
            rend.material = Resources.Load<Material>("Red");
            Debug.Log("Red");
              break;
          default:
            rend.material = Resources.Load<Material>("DefoltSkin");
              break;
      }

     
 }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
