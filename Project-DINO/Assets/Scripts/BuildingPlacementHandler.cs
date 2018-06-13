using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacementHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out hit))
        {
            transform.position = new Vector3(hit.point.x + 500, 2513, hit.point.z + 500);
        }

        if (Input.GetMouseButtonDown(0)) Destroy(this.gameObject.GetComponent<BuildingPlacementHandler>());
        else if (Input.GetMouseButtonDown(1)) Destroy(this.gameObject);

        if (Input.GetKeyDown(KeyCode.R)) this.transform.rotation = Quaternion.Euler(new Vector3(0, 90 + this.transform.rotation.eulerAngles.y, 0));
    }
}
