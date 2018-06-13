using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingClickScript : MonoBehaviour {

    public string buildingTitle;
    public string buildingDescription;
    public string buttonOneText;
    public string buttonTwoText;
    public string buttonThreeText;
    public string buttonFourText;
    public string buttonFiveText;
    public string buttonSixText;

    // Use this for initialization
    void Start ()
    {
		
	}

    void OnMouseDown()
    {
        ButtonHandler.buildingDataPane.SetActive(true);
        ButtonHandler.buildingDataPane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = buildingTitle;
        ButtonHandler.buildingDataPane.transform.Find("Description").GetComponent<UnityEngine.UI.Text>().text = buildingDescription;
        ButtonHandler.buildingDataPane.transform.Find("B1").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonOneText;
        ButtonHandler.buildingDataPane.transform.Find("B2").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonTwoText;
        ButtonHandler.buildingDataPane.transform.Find("B3").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonThreeText;
        ButtonHandler.buildingDataPane.transform.Find("B4").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonFourText;
        ButtonHandler.buildingDataPane.transform.Find("B5").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonFiveText;
        ButtonHandler.buildingDataPane.transform.Find("B6").Find("Text").GetComponent<UnityEngine.UI.Text>().text = buttonSixText;
    }
}
