using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    public static GameObject mapPane;
    public static GameObject optionsPane;
    public static GameObject buildPane;
    public static GameObject buildingDataPane;
    public static GameObject environmentPane;
    public static GameObject digSitePane;

    public void Start()
    {
        mapPane = GameObject.Find("MapPane");
        optionsPane = GameObject.Find("OptionsPane");
        buildPane = GameObject.Find("BuildPane");
        buildingDataPane = GameObject.Find("BuildingDataPane");
        environmentPane = GameObject.Find("EnvironmentPane");
        digSitePane = GameObject.Find("SiteDataPane");
        mapPane.SetActive(false);
        optionsPane.SetActive(false);
        buildPane.SetActive(false);
        buildingDataPane.SetActive(false);
        environmentPane.SetActive(false);
        digSitePane.SetActive(false);

    }

    public void ButtonPressed(string button)
    {
        //menu buttons
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
        if (button.Equals("environment"))
        {
            environmentPane.SetActive(!environmentPane.activeInHierarchy);
        }
        if (button.Equals("options"))
        {
            optionsPane.SetActive(!optionsPane.activeInHierarchy);
        }

        //build buttons
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
            fence.AddComponent<FencePlacementScript>();
            buildPane.SetActive(false);
        }
        if (button.Equals("buyhotel"))
        {
            GameObject o = Instantiate(GameObject.Find("hotel"));
            o.SetActive(true);
            o.AddComponent<BuildingPlacementHandler>();
            buildPane.SetActive(false);
        }

        //environment buttons
        if (button.Equals("upterrain"))
        {
            MainGameHandler.selectedMouseTool = "up";
        }
        if (button.Equals("downterrain"))
        {
            MainGameHandler.selectedMouseTool = "down";
        }

        //dig site buttons
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
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Texas, USA";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$750";
        }
        if (button.Equals("Site3"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #3";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Ethiopa, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$1550";
        }
        if (button.Equals("Site4"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #4";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Wyoming, USA";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$1650";
        }
        if (button.Equals("Site5"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #5";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Tanzania, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$1850";
        }
        if (button.Equals("Site6"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #6";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Morroco, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2350";
        }
        if (button.Equals("Site7"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #7";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Argentina, South America";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site8"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #8";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Alberta, Canada";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site9"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #9";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Kazakhstan, Asia";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site10"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #10";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Brazil, South America";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site11"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #11";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Novia Scotia, Canada";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site12"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #12";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Germany, Europe";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site13"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #13";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Ukraine, Europe";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site14"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #14";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Egypt, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site15"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #15";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Western Australia";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site16"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #16";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Northern Australia";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site17"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #17";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Niger, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site18"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #18";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Chad, Africa";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site19"))
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #19";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "New Mexico, USA";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Site20"))    
        {
            digSitePane.SetActive(true);
            digSitePane.transform.Find("Title").GetComponent<UnityEngine.UI.Text>().text = "Site #20";
            digSitePane.transform.Find("Location").GetComponent<UnityEngine.UI.Text>().text = "Brazil, South America";
            digSitePane.transform.Find("Cost").GetComponent<UnityEngine.UI.Text>().text = "$2650";
        }
        if (button.Equals("Dig"))
        {
            SceneManager.LoadScene("DigScene");
        }

        //building specific buttons
        if (button.Equals("B1"))
        {

        }
        if (button.Equals("B2"))
        {

        }
        if (button.Equals("B3"))
        {

        }
        if (button.Equals("B4"))
        {

        }
        if (button.Equals("B5"))
        {

        }
        if (button.Equals("B6"))
        {

        }
    }

}
