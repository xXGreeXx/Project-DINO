using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreenManager : MonoBehaviour {

    public static string TargetScene;
    GameObject slider;
    AsyncOperation ao;

    void Start()
    {
        slider = GameObject.Find("Slider");
        ao = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(TargetScene, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    void FixedUpdate ()
    {
        slider.GetComponent<UnityEngine.UI.Slider>().value = ao.progress;
	}
}
