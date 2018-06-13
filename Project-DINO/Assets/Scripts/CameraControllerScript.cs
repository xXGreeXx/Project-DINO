﻿using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    Vector3 target = new Vector3(-9797, 2458, -4142);
    float xVel = 0;
    float yVel = 0;

    //start
    void Start()
    {
        transform.LookAt(target);
    }

    //update
    void Update()
    {
        //scroll camera in and out
        if (Input.GetAxis("Mouse ScrollWheel") > 0f && Camera.main.fieldOfView > 5)
        {
            Camera.main.fieldOfView -= 5;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f && Camera.main.fieldOfView < 95)
        {
            Camera.main.fieldOfView += 5;
        }

        //rotate camera
        if (Input.GetMouseButton(0))
        {
            transform.LookAt(target);
            transform.RotateAround(target, Vector3.up, Input.GetAxis("Mouse X") * 2);
        }

        //move target
        if (Input.GetKey(KeyCode.W)) yVel = 15;
        else if (Input.GetKey(KeyCode.S)) yVel = -15;
        else yVel = 0;

        if (Input.GetKey(KeyCode.A)) xVel = 15;
        else if (Input.GetKey(KeyCode.D)) xVel = -15;
        else xVel = 0;

        Vector3 relative = this.transform.forward;

        this.transform.position += Vector3.Scale(new Vector3(xVel, 0, yVel), relative);
        target += Vector3.Scale(new Vector3(xVel, 0, yVel), relative);
    }
}
