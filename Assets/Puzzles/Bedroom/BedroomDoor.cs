using UnityEngine;
using System.Collections;

public class BedroomDoor : MonoBehaviour {

    private DialogSystem dialog;

    private RoomScript room;

    private bool hasMentionedDrinking;

	// Use this for initialization
	void Start () {
        dialog = FindObjectOfType<DialogSystem>();
        room = FindObjectOfType<RoomScript>();
	}
	
    public void Interact() {
        if (hasMentionedDrinking)
            room.GoToNextLevel();
        else {
            hasMentionedDrinking = true;
            dialog.ShowText("Wait. Do I forget something ?");
        }
    }
}
