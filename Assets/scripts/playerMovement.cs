using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpStrength;
    public bool onGround = true;
    public const int MAX_JUMPS = 2;
    public int currentJump = 0;
    public Camera cam;
    public Joystick joystick;
    float xSpeed;
    float zSpeed;
    public float speedOnAir = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        xSpeed = Input.GetAxis("Horizontal");//joystick.Horizontal;
        zSpeed = Input.GetAxis("Vertical");//joystick.Vertical;
        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;

         Vector3 desiredMove = forward * -xSpeed + right * zSpeed;
        //
        
            rb.AddTorque(desiredMove * speed * 15);
        if (xSpeed > 0)
            rb.AddForce(right * 0.7f);
        else if (xSpeed < 0)
            rb.AddForce(-right * 0.7f);

        if (zSpeed > 0)
            rb.AddForce(forward * 0.7f);
        else if (zSpeed < 0)
            rb.AddForce(-forward * 0.7f);

        if (Input.GetKeyDown("space") && (onGround || MAX_JUMPS > currentJump))
        {
          
            jump();
            
        }
    }

    public void jump()
    {
        if (onGround || MAX_JUMPS > currentJump)
        {
            // rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            rb.velocity += jumpStrength * Vector3.up;
            onGround = false;

            currentJump++;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ground"))
        {
            onGround = true;
            currentJump = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
     
       
    }




}
