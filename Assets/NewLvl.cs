using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform perfabToSpawn;
    public Transform perfabToSpawn2;

    bool isCollide = true;

    private void OnCollisionEnter(Collision collision)
    {
   
        if(GetComponent<Collider>().tag == "Player"){
            
            if(isCollide){
                Debug.Log("wer2");
                for(int i = 0; i < 200; i++){
                    Vector3 spawnPoint = transform.position + Random.insideUnitSphere * 40;
                    if(i % 2 == 0)
                    Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation);
                    else
                    Instantiate(perfabToSpawn2,spawnPoint,perfabToSpawn.rotation);
                }
                isCollide = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
