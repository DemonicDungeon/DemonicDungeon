using UnityEngine;
using System.Collections;

public class SelectableObject : MonoBehaviour {

    private MeshRenderer renderer;

    public Material selectedMaterial;
    private Material originalMaterial;

    public void Select() {
        renderer.material = selectedMaterial;
    }

    public void Unselect() {
        Debug.Log("UNSELECT");
        renderer.material = originalMaterial;
    }

	// Use this for initialization
	void Start () {
        renderer = GetComponent<MeshRenderer>();
        originalMaterial = renderer.material;
    }
	
}
