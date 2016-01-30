using UnityEngine;
using System.Collections;

public class SelectableObject : MonoBehaviour {

    private MeshRenderer myRenderer;
    
    public void Select() {
        myRenderer.material.EnableKeyword("_EMISSION");
        myRenderer.material.SetColor("_EmissionColor", new Color(0.1703071f, 0.2858967f, 0.3088235f));
    }

    public void Unselect() {
        myRenderer.material.SetColor("_EmissionColor", new Color(0,0,0));
    }

    // Use this for initialization
    void Start () {
        myRenderer = GetComponent<MeshRenderer>();
    }
	
}
