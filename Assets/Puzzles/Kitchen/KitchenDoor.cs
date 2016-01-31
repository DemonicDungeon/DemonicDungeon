using UnityEngine;
using System.Collections;

public class KitchenDoor : MonoBehaviour {

	private RoomScript room;
	private KitchenScript puzzle;
	private DialogSystem dialog;


	// Use this for initialization
	void Start () {

		room = FindObjectOfType<RoomScript>();
		puzzle = FindObjectOfType<KitchenScript> ();
		dialog = FindObjectOfType<DialogSystem> ();
	}

	void Interact() {
		if (puzzle.is_complete()) {
			dialog.ShowText ("Ahhh!! Much better now");
			room.GoToNextLevel ();
		} else {
			dialog.ShowText ("Can't just leave it boiling here!");
		}
	}
}
