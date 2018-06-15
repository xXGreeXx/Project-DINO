using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehaviorScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        if (Random.Range(0, 100) < 10)
        {
            GameObject bone = GameObject.Instantiate(GameObject.Find("Bone"));
            bone.transform.parent = this.transform;
            bone.transform.localPosition = new Vector3(0, 0, 0);

            this.transform.gameObject.tag = "Bone";
        }	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if(ToolSelection.toolSelected.Equals("chisel")) GetComponent<Rigidbody>().isKinematic = false;
        if (ToolSelection.toolSelected.Equals("hammer"))
        {
            //for(int i = 0; i < 100; i++)
            //{
            //    GameObject dustObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //    dustObject.tag = "Dust";
            //    dustObject.transform.position = this.transform.position;
            //    dustObject.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
            //    dustObject.GetComponent<Renderer>().material.color = Color.red;
            //    Rigidbody body = dustObject.AddComponent<Rigidbody>();
            //    body.mass = 1000;
            //    body.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            //}
            Destroy(this.gameObject);
        }
        if (ToolSelection.toolSelected.Equals("brush"))
        {

        }
    }
}
