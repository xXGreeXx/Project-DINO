using System.Linq;
using UnityEngine;

public class MeshInverter : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
