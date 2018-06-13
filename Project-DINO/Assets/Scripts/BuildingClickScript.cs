using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingClickScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnMouseDown()
    {
        ButtonHandler.buildingDataPane.SetActive(true);    
    }
}
