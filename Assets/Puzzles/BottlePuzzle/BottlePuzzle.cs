using UnityEngine;
using System.Collections;

public class BottlePuzzle : MonoBehaviour {
    private RoomScript room;

    private int BottleCount = 0;

    public void PickedUpBottle() {
        BottleCount++;
        if (BottleCount == 3)
            room.GoToNextLevel();
    }

	void Start () {
        room = FindObjectOfType<RoomScript>();
	}
}
