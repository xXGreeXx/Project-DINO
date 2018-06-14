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
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    raiselowerTerrainArea(hit.point - t.transform.position, 10, 10, 5, 0.01f);
                }
            }
        }
        if (selectedMouseTool.Equals("down") && Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    raiselowerTerrainArea(hit.point - t.transform.position, 10, 10, 5, -0.01f);
                }
            }
        }
    }

    //raise/lower terrain area at pos
    private void raiselowerTerrainArea(Vector3 point, int lenx, int lenz, int smooth, float incdec)
    {
        int areax;
        int areaz;
        smooth += 1;
        float smoothing;
        int terX = (int)((point.x / t.terrainData.size.x) * t.terrainData.heightmapWidth);
        int terZ = (int)((point.z / t.terrainData.size.z) * t.terrainData.heightmapHeight);
        lenx += smooth;
        lenz += smooth;
        terX -= (lenx / 2);
        terZ -= (lenz / 2);
        if (terX < 0) terX = 0;
        if (terX > t.terrainData.heightmapWidth) terX = t.terrainData.heightmapWidth;
        if (terZ < 0) terZ = 0;
        if (terZ > t.terrainData.heightmapHeight) terZ = t.terrainData.heightmapHeight;
        float[,] heights = t.terrainData.GetHeights(terX, terZ, lenx, lenz);
        float y = heights[lenx / 2, lenz / 2];
        y += incdec;
        for (smoothing = 1; smoothing < smooth + 1; smoothing++)
        {
            float multiplier = smoothing / smooth;
            for (areax = (int)(smoothing / 2); areax < lenx - (smoothing / 2); areax++)
            {
                for (areaz = (int)(smoothing / 2); areaz < lenz - (smoothing / 2); areaz++)
                {
                    if ((areax > -1) && (areaz > -1) && (areax < t.terrainData.heightmapWidth) && (areaz < t.terrainData.heightmapHeight))
                    {
                        heights[areax, areaz] = Mathf.Clamp((float)y * multiplier, 0, 1);
                    }
                }
            }
        }
        t.terrainData.SetHeights(terX, terZ, heights);
    }

    //raise/lower terrain at pos
    private void raiselowerTerrainPoint(Vector3 point, float incdec)
    {
        int terX = (int)((point.x / t.terrainData.size.x) * t.terrainData.heightmapWidth);
        int terZ = (int)((point.z / t.terrainData.size.z) * t.terrainData.heightmapHeight);
        float y = originalHeights[terX, terZ];
        y += incdec;
        float[,] height = new float[1, 1];
        height[0, 0] = Mathf.Clamp(y, 0, 1);
        originalHeights[terX, terZ] = Mathf.Clamp(y, 0, 1);
        t.terrainData.SetHeights(terX, terZ, height);
    }
}
