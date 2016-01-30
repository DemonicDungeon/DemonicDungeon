using UnityEngine;
using System.Collections;

public class CorridorDoor : MonoBehaviour {

    private RoomScript room;
    private DialogSystem dialog;
    public CorridorPuzzle puzzle;

    public void Interact() {
        if (puzzle.LevelComplete) {
            room.GoToNextLevel();            
        } else {
            dialog.ShowText("There's a scary ghost in the way!!");
        }
    }

    void Start() {
        room = FindObjectOfType<RoomScript>();
        dialog = FindObjectOfType<DialogSystem>();
        puzzle = FindObjectOfType<CorridorPuzzle>();
    }
}
