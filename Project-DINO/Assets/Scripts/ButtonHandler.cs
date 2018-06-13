using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    public static GameObject mapPane;
    public static GameObject optionsPane;
    public static GameObject buildPane;
    public static GameObject buildingDataPane;
    public static GameObject digSitePane;

    public void Start()
    {
        mapPane = GameObject.Find("MapPane");
        optionsPane = GameObject.Find("OptionsPane");
        buildPane = GameObject.Find("BuildPane");
        buildingDataPane = GameObject.Find("BuildingDataPane");
        digSitePane = GameObject.Find("SiteDataPane");
        mapPane.SetActive(false);
        optionsPane.SetActive(false);
        buildPane.SetActive(false);
        buildingDataPane.SetActive(false);
        digSitePane.SetActive(false);
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
            GameObject sidewalk = GameObject.CreatePrimitive(PrimitiveType.Plane);
            sidewalk.transform.localScale = new Vector3(8, 2, 35);
            sidewalk.AddComponent<BuildingPlacementHandler>();

            sidewalk.GetComponent<Renderer>().material = Resources.Load("sidewalkMat", typeof(Material)) as Material;
            buildPane.SetActive(false);
        }
        if (button.Equals("buyelectricfence"))
        {
            GameObject fence = Instantiate(GameObject.Find("fence"));
            fence.AddComponent<BuildingPlacementHandler>();
            buildPane.SetActive(false);
        }
        if (button.Equals("Site1"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #1";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Arizona, USA";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$550";
        }
        if (button.Equals("Site2"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #2";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Arizona, USA";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$750";
        }
    }

}
