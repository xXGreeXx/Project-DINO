using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    public static GameObject mapPane;
    public static GameObject optionsPane;
    public static GameObject buildPane;
    public static GameObject buildingDataPane;
    public static GameObject environmentPane;
    public static GameObject inventoryPane;
    public static GameObject digSitePane;

    public static GameObject newGamePane;
    public static GameObject loadGamePane;

    public void Start()
    {
        mapPane = GameObject.Find("MapPane");
        optionsPane = GameObject.Find("OptionsPane");
        buildPane = GameObject.Find("BuildPane");
        buildingDataPane = GameObject.Find("BuildingDataPane");
        environmentPane = GameObject.Find("EnvironmentPane");
        inventoryPane = GameObject.Find("InventoryPane");
        digSitePane = GameObject.Find("SiteDataPane");
        newGamePane = GameObject.Find("NewGamePanel");
        loadGamePane = GameObject.Find("LoadGamePanel");
        if (mapPane != null) mapPane.SetActive(false);
        if (optionsPane != null) optionsPane.SetActive(false);
        if (buildPane != null) buildPane.SetActive(false);
        if (buildingDataPane != null) buildingDataPane.SetActive(false);
        if (environmentPane != null) environmentPane.SetActive(false);
        if (inventoryPane != null) inventoryPane.SetActive(false);
        if (digSitePane != null) digSitePane.SetActive(false);

        if (newGamePane != null) newGamePane.SetActive(false);
        if (loadGamePane != null) loadGamePane.SetActive(false);
    }

    public void ButtonPressed(string button)
    {
        //main menu buttons
        if (button.Equals("Continue"))
        {

        }
        if (button.Equals("New"))
        {
            newGamePane.SetActive(true);
            loadGamePane.SetActive(false);
        }
        if (button.Equals("Load"))
        {
            loadGamePane.SetActive(true);
            newGamePane.SetActive(false);
        }
        if (button.Equals("begin"))
        {
            MainGameHandler.money = int.Parse(newGamePane.transform.Find("MoneyBox").Find("Text").GetComponent<UnityEngine.UI.Text>().text.Substring(1));
            MainGameHandler.parkName = newGamePane.transform.Find("NameBox").Find("Text").GetComponent<UnityEngine.UI.Text>().text;

            LoadScreenManager.TargetScene = "Game";
            SceneManager.LoadScene("LoadScene");
        }
        if (button.Equals("Exit"))
        {
            Application.Quit();
        }

        //dig site buttons
        if (button.Equals("ReturnPark"))
        {
            LoadScreenManager.TargetScene = "Game";
            SceneManager.LoadScene("LoadScene");
        }

        //in game menu buttons
        if (button.Equals("return"))
        {
            optionsPane.SetActive(false);
        }
        if (button.Equals("save"))
        {
            MainGameHandler.SaveGameData();
        }
        if (button.Equals("returnmenu"))
        {
            MainGameHandler.SaveGameData();
            LoadScreenManager.TargetScene = "MainMenu";
            SceneManager.LoadScene("LoadScene");
        }
        if (button.Equals("exitgame"))
        {
            MainGameHandler.SaveGameData();
            Application.Quit();
        }

        //menu buttons
        if (button.Equals("map"))
        {
            mapPane.SetActive(!mapPane.activeInHierarchy);
            buildPane.SetActive(false);
            inventoryPane.SetActive(false);
        }
        if (button.Equals("build"))
        {
            buildPane.SetActive(!buildPane.activeInHierarchy);
            mapPane.SetActive(false);
            inventoryPane.SetActive(false);
        }
        if (button.Equals("inventory"))
        {
            inventoryPane.SetActive(!inventoryPane.activeInHierarchy);
            mapPane.SetActive(false);
            buildPane.SetActive(false);
        }
        if (button.Equals("environment"))
        {
            environmentPane.SetActive(!environmentPane.activeInHierarchy);
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
            o.AddComponent<BuildingPlacementHandler>();
            buildPane.SetActive(false);
        }
        if (button.Equals("buygenomelab"))
        {
            GameObject o = Instantiate(GameObject.Find("laboratory"));
            o.AddComponent<BuildingPlacementHandler>();
            buildPane.SetActive(false);

            BuildingClickScript c = o.AddComponent<BuildingClickScript>();
            c.buildingTitle = "Genome Lab";
            c.buildingDescription = "The genome lab lets you genetically modify your dinosaurs. You can easily change and synthesize their genetics to create whatever you please.";
            c.buttonOneText = "Open";
            c.buttonTwoText = "Close";
            c.buttonThreeText = "Laboratory";
            c.buttonFourText = "";
            c.buttonFiveText = "Move";
            c.buttonSixText = "Demolish";
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
            LoadScreenManager.TargetScene = "DigScene";
            SceneManager.LoadScene("LoadScene");
        }

        //building specific buttons
        if (button.Equals("B1"))
        {
            if (MainGameHandler.selectedBuilding.name.Equals("Gate"))
            {
                MainGameHandler.selectedBuilding.GetComponent<Animator>().Play("State 0 0", 0);
                MainGameHandler.selectedBuilding.GetComponent<Animator>().Play("State 0 0 0", 0);
            }
        }
        if (button.Equals("B2"))
        {
            if (MainGameHandler.selectedBuilding.name.Equals("Gate"))
            {
                MainGameHandler.selectedBuilding.GetComponent<Animator>().Play("State 0", 0);
                MainGameHandler.selectedBuilding.GetComponent<Animator>().Play("State 0", 1);
            }
        }
        if (button.Equals("B3"))
        {

        }
        if (button.Equals("B4"))
        {

        }
        if (button.Equals("B5"))
        {
            MainGameHandler.selectedBuilding.AddComponent<BuildingPlacementHandler>();
        }
        if (button.Equals("B6"))
        {
            Destroy(MainGameHandler.selectedBuilding);
            MainGameHandler.selectedBuilding = null;
        }
    }

}
