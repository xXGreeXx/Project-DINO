using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMoveScript : MonoBehaviour {

    public static bool bringInBoat = true;
    float speed = 500;
    bool down = false;

    int amountOfPeopleOnBoat = 3500;

	void Start ()
    {
	}

    void Update()
    {
        //move boat into dock
        if (bringInBoat && speed > 0)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

            if (transform.position.x > -14600)
            {
                speed -= 1.25F;
            }
        }

        //lower door
        if(speed <= 0 && !down)
        {
            this.gameObject.GetComponent<Animator>().Play("State 0", 0);
            down = true;
        }

        //unload passengers
        if (down && amountOfPeopleOnBoat > 0)
        {

        }
    }
}
