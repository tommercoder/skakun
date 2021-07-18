using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
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
    public Joystick cameraJoystick;
    public CinemachineFreeLook cinemachine;
    float xSpeed;
    float zSpeed;
    public float speedOnAir = 5;
    public float TouchSensitivity_x = 5;
    public float TouchSensitivity_y = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //CinemachineCore.GetInputAxis = HandleAxisInputDelegate;
    }
    //float HandleAxisInputDelegate(string axisName)
    //{
    //    switch (axisName)
    //    {

    //        case "Mouse X":

    //            if (Input.touchCount > 0)
    //            {
    //                return Input.touches[0].deltaPosition.x / TouchSensitivity_x;
    //            }
    //            else
    //            {
    //                return Input.GetAxis(axisName);
    //            }

    //        case "Mouse Y":
    //            if (Input.touchCount > 0)
    //            {
    //                return Input.touches[0].deltaPosition.y / TouchSensitivity_y;
    //            }
    //            else
    //            {
    //                return Input.GetAxis(axisName);
    //            }

    //        default:
    //            Debug.LogError("Input <" + axisName + "> not recognyzed.", this);
    //            break;
    //    }

    //    return 0f;
    //}
    private void Update()
    {
        xSpeed =joystick.Horizontal; //Input.GetAxis("Horizontal");
        zSpeed = joystick.Vertical; //Input.GetAxis("Vertical");

        cinemachine.m_XAxis.Value = cameraJoystick.Horizontal;
        cinemachine.m_YAxis.Value = cameraJoystick.Vertical;


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
        if(other.CompareTag("ground") || other.CompareTag("Bonus"))
        {
            onGround = true;
            currentJump = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
     
       
    }





}
