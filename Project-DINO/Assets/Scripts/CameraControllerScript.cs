using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    Vector3 target = new Vector3(-9797, 2458, -4142);
    float xVel = 0;
    float zVel = 0;

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
        if (Input.GetMouseButton(1))
        {
            transform.LookAt(target);
            transform.RotateAround(target, Vector3.up, Input.GetAxis("Mouse X") * 2);
        }

        //move target
        if (Input.GetKey(KeyCode.W)) zVel = 15;
        else if (Input.GetKey(KeyCode.S)) zVel = -15;
        else zVel = 0;

        if (Input.GetKey(KeyCode.A)) xVel = -15;
        else if (Input.GetKey(KeyCode.D)) xVel = 15;
        else xVel = 0;

        float xRot = this.transform.rotation.eulerAngles.x;
        float zRot = this.transform.rotation.eulerAngles.z;
        this.transform.rotation = Quaternion.Euler(0, this.transform.rotation.eulerAngles.y, 0);

        Vector3 moveZ = zVel * this.transform.forward;
        Vector3 moveX = xVel * this.transform.right;

        this.transform.position += moveX;
        this.transform.position += moveZ;
        target += moveX;
        target += moveZ;

        this.transform.rotation = Quaternion.Euler(xRot, this.transform.rotation.eulerAngles.y, zRot);
    }
}
