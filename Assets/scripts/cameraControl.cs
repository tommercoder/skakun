using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class cameraControl : MonoBehaviour
{
    public GameObject target;
    public float xOffset, yOffset, zOffset;
    public Joystick joystick;
    public CinemachineFreeLook cam;
    public int speed = 10;
    private void Update()
    {
        
       // transform.position = target.transform.position + (-target.transform.forward * new Vector3(xOffset,yOffset,zOffset).magnitude);
         transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
        cam.m_XAxis.Value = joystick.Horizontal;
        cam.m_YAxis.Value = joystick.Vertical;
        //transform.Rotate(Vector3.up, joystick.Vertical * speed);
       // transform.Rotate(Vector3.left, joystick.Vertical * speed);
        // transform.rotation = target.transform.rotation;

    }
}
