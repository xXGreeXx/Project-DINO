using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameHandlerForDigScene : MonoBehaviour {

    GameObject completePanel;

    void Start()
    {
        completePanel = GameObject.Find("CompletePanel");
        completePanel.SetActive(false);
    }

    void Update ()
    {
        GameObject[] rocks = GameObject.FindGameObjectsWithTag("Rock");

        if (rocks.Length == 0)
        {
            completePanel.SetActive(true);
        }
	}
}
