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
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");//joystick.Horizontal;
        float zSpeed = Input.GetAxis("Vertical");//joystick.Vertical;
        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;
        
        
        Vector3 desiredMove = forward * -xSpeed + right * zSpeed;
        rb.AddTorque(desiredMove * speed * Time.deltaTime*5);
        if(Input.GetKeyDown("space") && (onGround || MAX_JUMPS > currentJump))
        {
            jump();
        }

        

    }
    public void jump()
    {
        if (onGround || MAX_JUMPS > currentJump)
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            onGround = false;

            currentJump++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
        currentJump = 0;
    }




}
