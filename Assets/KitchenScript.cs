using UnityEngine;
using System.Collections;

public class KitchenScript : MonoBehaviour {

	private DialogSystem dialog;

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem> ();
		Intro ();
	
	}

	public void Intro() {
		dialog.ShowText ("Oh, looks like I tried to cook something. Should finish this thing, probably");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
