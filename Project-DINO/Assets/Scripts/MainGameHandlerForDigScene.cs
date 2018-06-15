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
            string findings = "Findings: \n";
            GameObject[] bones = GameObject.FindGameObjectsWithTag("Bone");
            foreach (GameObject bone in bones)
            {
                findings += bone.transform.Find("Artifact").tag + "\n";
            }

            completePanel.transform.Find("FindingsLabel").GetComponent<UnityEngine.UI.Text>().text = findings;
        }
	}
}
