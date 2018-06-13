using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingClickScript : MonoBehaviour {

    public string buildingTitle;
    public string buildingDescription;

	// Use this for initialization
	void Start ()
    {
		
	}

    void OnMouseDown()
    {
        ButtonHandler.buildingDataPane.SetActive(true);
        ButtonHandler.buildingDataPane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = buildingTitle;
        ButtonHandler.buildingDataPane.transform.Find("Description").GetComponent<UnityEngine.UI.Text>().text = buildingDescription;
    }
}
