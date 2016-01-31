using UnityEngine;
using System.Collections;

public class CauldronIngredient : MonoBehaviour {
	private DialogSystem dialog;
	private KitchenScript kitchen;

	void Interact() {
		dialog.ShowText("You picked up jalapeno powder.");
		kitchen.IngridientSelected (this);
		gameObject.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem>();
		kitchen = FindObjectOfType<KitchenScript> ();
	}

}
