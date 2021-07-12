using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public Transform Object;
    public Transform Boy;
public Transform perfabToSpawn;
public Transform perfabToSpawn2;
//public int objectCount = 50;
public float spawnRadius = 5;

public float spawnCollisionCheckRadius = 5;

public List<Object> list;
void Start(){

    SetPlane();

    SpawnPrefabs();

    searchSpawn();


}

void SpawnPrefabs(){

    for(int i = 0; i < ShowCount.PlatformsCount; i++){
        Vector3 spawnPoint = transform.position + Random.insideUnitSphere * spawnRadius;

        if(SetTougle.Collision){
            if(i % 2 == 0){
                //Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation);
                list.Add(Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation));
            }        
            else{
                list.Add(Instantiate(perfabToSpawn2,spawnPoint,perfabToSpawn.rotation));
            }
        }else{
        if(!Physics.CheckSphere(spawnPoint,spawnCollisionCheckRadius)){
            if(i % 2 == 0){
                //Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation);
                list.Add(Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation));
            }        
            else{
                list.Add(Instantiate(perfabToSpawn2,spawnPoint,perfabToSpawn.rotation));
            }
        }
        }
    }
}

void SetPlane(){

    if(ShowCount.PlatformsCount < 20){
        spawnRadius = 15;
    }else if(ShowCount.PlatformsCount < 50 && ShowCount.PlatformsCount > 20){
        spawnRadius = 20;
    }else if(ShowCount.PlatformsCount < 70 && ShowCount.PlatformsCount > 50){
        spawnRadius = 25;
    }else if(ShowCount.PlatformsCount > 70){
        spawnRadius = 30;
    }
    
    Vector3 PlaneVec = new Vector3(0,-spawnRadius+100,0);
    Object.transform.position = PlaneVec;
    Boy.transform.position = new Vector3(0,-spawnRadius + 110,0);

    
    

}

public void searchSpawn(){
    Vector3 spawnPoint = transform.position + Random.insideUnitSphere * spawnRadius;
    for(int i = 0; i < ShowCount.PlatformsCount; i++){
        
           // Debug.Log("Point");
    }

    

} 


}
