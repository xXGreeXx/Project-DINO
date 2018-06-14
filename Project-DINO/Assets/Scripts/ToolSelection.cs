using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSelection : MonoBehaviour {

    public static string toolSelected = "chisel";

	// Use this for initialization
	void Start ()
    {
        GameObject.Find("chisel").GetComponent<Renderer>().material.color = Color.gray;
        GameObject.Find("hammer").GetComponent<Renderer>().material.color = Color.gray;
        GameObject.Find("brush").GetComponent<Renderer>().material.color = Color.gray;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        GameObject.Find("chisel").GetComponent<Renderer>().material.color = Color.gray;
        GameObject.Find("hammer").GetComponent<Renderer>().material.color = Color.gray;
        GameObject.Find("brush").GetComponent<Renderer>().material.color = Color.gray;

        this.GetComponent<Renderer>().material.color = Color.yellow;
        toolSelected = this.name;
    }
}
