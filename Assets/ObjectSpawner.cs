using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
public Transform perfabToSpawn;
public Transform perfabToSpawn2;
public int objectCount = 50;
public float spawnRadius = 5;

void Start(){
    for(int i = 0; i < objectCount; i++){
        Vector3 spawnPoint = transform.position + Random.insideUnitSphere * spawnRadius;
        if(i % 2 == 0)
        Instantiate(perfabToSpawn,spawnPoint,perfabToSpawn.rotation);
        else
        Instantiate(perfabToSpawn2,spawnPoint,perfabToSpawn.rotation);
    }
}


}
