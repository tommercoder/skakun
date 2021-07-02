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
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }


}
