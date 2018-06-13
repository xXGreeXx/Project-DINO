using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    public static GameObject mapPane;
    public static GameObject optionsPane;
    public static GameObject buildPane;
    public static GameObject buildingDataPane;

    public void Start()
    {
        mapPane = GameObject.Find("MapPane");
        optionsPane = GameObject.Find("OptionsPane");
        buildPane = GameObject.Find("BuildPane");
        buildingDataPane = GameObject.Find("BuildingDataPane");
        mapPane.SetActive(false);
        optionsPane.SetActive(false);
        buildPane.SetActive(false);
        buildingDataPane.SetActive(false);
    }

    public void ButtonPressed(string button)
    {
        if (button.Equals("map"))
        {
            mapPane.SetActive(!mapPane.activeInHierarchy);
            buildPane.SetActive(false);
        }
        if (button.Equals("build"))
        {
            buildPane.SetActive(!buildPane.activeInHierarchy);
            mapPane.SetActive(false);
        }
        if (button.Equals("options"))
        {
            optionsPane.SetActive(!optionsPane.activeInHierarchy);
        }
        if (button.Equals("buysidewalk"))
        {
            
        }
    }

}
