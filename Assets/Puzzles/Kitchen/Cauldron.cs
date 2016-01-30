using UnityEngine;
using System.Collections;

public class Cauldron : MonoBehaviour {
	private DialogSystem dialog;
	public void Interact() {
		dialog.ShowText ("You don't have all ingredients");
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
