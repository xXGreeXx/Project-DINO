using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FencePlacementScript : MonoBehaviour {

    public bool placedFirstFence = false;

	// Update is called once per frame
	void Update ()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(this.transform.position).z;
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        pos.y = 2459;

        if (!placedFirstFence)
        {
            this.transform.position = pos;

            if (Input.GetMouseButtonDown(0))
            {
                Destroy(this.gameObject.GetComponent<FencePlacementScript>());

                GameObject pivot = new GameObject("Pivot");
                pivot.transform.position = this.transform.position + (-transform.forward * 50);

                GameObject fence = Instantiate(GameObject.Find("fence"));
                fence.transform.SetParent(pivot.transform);
                fence.AddComponent<FencePlacementScript>().placedFirstFence = true;
                fence.transform.position = this.transform.position + (-transform.forward * 80);
            }
            else if (Input.GetMouseButtonDown(1)) Destroy(this.gameObject);

            if (Input.GetKeyDown(KeyCode.R)) this.transform.rotation = Quaternion.Euler(new Vector3(0, 90 + this.transform.rotation.eulerAngles.y, 0));
        }
        else
        {
            this.transform.parent.LookAt(pos);

            if (Input.GetMouseButtonDown(0))
            {
                Destroy(this.gameObject.GetComponent<FencePlacementScript>());

                GameObject pivot = new GameObject("Pivot");
                pivot.transform.position = this.transform.position + (-transform.forward * 50);

                GameObject fence = Instantiate(GameObject.Find("fence"));
                fence.transform.SetParent(pivot.transform);
                fence.AddComponent<FencePlacementScript>().placedFirstFence = true;
                fence.transform.position = this.transform.position + (-transform.forward * 80);
            }
            else if (Input.GetMouseButtonDown(1)) Destroy(this.gameObject);
        }
    }
}
