using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameHandler : MonoBehaviour {

    public static string selectedMouseTool = string.Empty;
    Terrain t;
    float[,] originalHeights;

    // Use this for initialization
    void Start ()
    {
        t = GameObject.Find("Terrain").GetComponent<Terrain>();
        originalHeights = t.terrainData.GetHeights(0, 0, t.terrainData.heightmapWidth, t.terrainData.heightmapHeight);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //handle mouse tools
        if (selectedMouseTool.Equals("up") && Input.GetMouseButton(0))
        {
            Vector3 pos = Vector3.zero;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                pos = hit.point;
            }

            float x = pos.x - t.transform.position.x;
            float y = pos.z - t.transform.position.z;
            Debug.Log(originalHeights.Length);
            originalHeights[(int)x, (int)y] = 1F;

            t.terrainData.SetHeights(0, 0, originalHeights);
        }
	}
}
