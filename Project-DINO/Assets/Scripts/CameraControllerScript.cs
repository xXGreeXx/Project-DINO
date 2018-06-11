using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    Vector3 target = new Vector3(-638, 0, -244);

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

        //move camera
        if (Input.GetMouseButton(0))
        {
            transform.LookAt(target);
            transform.RotateAround(target, Vector3.up, Input.GetAxis("Mouse X") * 2);
        }
    }
}
