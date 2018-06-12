using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMoveScript : MonoBehaviour {

    public static bool bringInBoat = true;
    float speed = 500;

	void Start ()
    {
	}

    void Update()
    {
        if (bringInBoat && speed > 0)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

            if (transform.position.x > -14670)
            {
                speed -= 1.25F;
            }
        }
    }
}
