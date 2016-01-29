using UnityEngine;
using System.Collections;

public class PlayerSelect : MonoBehaviour {

    private Camera myCamera;

    public float range;

    private SelectableObject LastSelected;

    // Use this for initialization
    void Start () {
        myCamera = GetComponent<Camera>();
	}

    public void Unselect() {
        if (LastSelected) {
            LastSelected.Unselect();
            LastSelected = null;
        }
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = myCamera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, range)) {

            SelectableObject selected = hit.collider.GetComponent<SelectableObject>();
            if (selected != null && selected != LastSelected) {
                Unselect();
                selected.Select();
                LastSelected = selected;
            }

        } else {
            Unselect();
        }

        if (Input.GetButtonDown("Fire1")) {
            if (LastSelected) {
                LastSelected.SendMessage("Interact");
            }
        }
    }
}
