﻿using UnityEngine;
using System.Collections;

public class BottlePuzzle : MonoBehaviour {

   

    private RoomScript room;

    public int BottleCount = 0;

    public void PickedUpBottle() {
        BottleCount++;
        if (BottleCount == 3)
            room.GoToNextLevel();
    }

	// Use this for initialization
	void Start () {
        room = FindObjectOfType<RoomScript>();
	}
}
