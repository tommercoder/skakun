using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpStrength;
    public bool onGround = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        rb.AddTorque(new Vector3(xSpeed, 0, ySpeed) * speed * Time.deltaTime*5);
        if(Input.GetKeyDown("space") && onGround)
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            onGround = false;
        }

        

    }
    public Transform perfabToSpawn;
    public Transform perfabToSpawn2;

    bool isCollide = true;

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
   
        if(collision.collider.tag == "Spawner"){
            
            if(isCollide){
                Debug.Log("wer");
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




}
