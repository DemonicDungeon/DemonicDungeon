using UnityEngine;
using System.Collections;

public class SelectableObject : MonoBehaviour {

    private MeshRenderer renderer;

    public Material selectedMaterial;
    private Material originalMaterial;

    public void Select() {
        //    renderer.material = selectedMaterial;
        renderer.material.EnableKeyword("_EMISSION");
        renderer.material.SetColor("_EmissionColor", new Color(0.1703071f, 0.2858967f, 0.3088235f));
    }

    public void Unselect() {
      //  renderer.material = originalMaterial;
        renderer.material.SetColor("_EmissionColor", new Color(0,0,0));

    }

    // Use this for initialization
    void Start () {
        renderer = GetComponent<MeshRenderer>();
        originalMaterial = renderer.material;
    }
	
}
