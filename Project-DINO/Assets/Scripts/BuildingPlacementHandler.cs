using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacementHandler : MonoBehaviour {

    //Use this for initialization
    void Start ()
    {

    }

    void Update()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(this.transform.position).z;
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        pos.y = 2460;
        this.transform.position = pos;

        if (Input.GetMouseButtonDown(0)) Destroy(this.gameObject.GetComponent<BuildingPlacementHandler>());
        else if (Input.GetKeyDown(KeyCode.B)) Destroy(this.gameObject);

        if (Input.GetKeyDown(KeyCode.R)) this.transform.rotation = Quaternion.Euler(new Vector3(0, 90 + this.transform.rotation.eulerAngles.y, 0));
    }
}
