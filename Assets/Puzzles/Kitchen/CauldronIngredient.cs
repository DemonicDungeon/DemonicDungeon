using UnityEngine;
using System.Collections;

public class CauldronIngredient : MonoBehaviour {
	private DialogSystem dialog;

	void Interact() {
		dialog.ShowText("You picked up jalapeno powder.");
		gameObject.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem>();
	}

}
