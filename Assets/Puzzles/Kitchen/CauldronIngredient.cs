using UnityEngine;
using System.Collections;

public class CauldronIngredient : MonoBehaviour {
	private DialogSystem dialog;
	private KitchenScript kitchen;

	void Interact() {
		kitchen.IngridientSelected (this);
		gameObject.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem>();
		kitchen = FindObjectOfType<KitchenScript> ();
	}

}
