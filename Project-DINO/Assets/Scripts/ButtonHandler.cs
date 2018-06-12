using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    GameObject mapPane;

    public void Start()
    {
        mapPane = GameObject.Find("MapPane");
        mapPane.SetActive(false);
    }

    public void ButtonPressed(string button)
    {
        Debug.Log("True");
        if (button.Equals("map"))
        {
            mapPane.SetActive(!mapPane.activeInHierarchy);
        }
    }

}
