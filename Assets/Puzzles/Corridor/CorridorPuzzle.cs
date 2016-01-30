using UnityEngine;
using System.Collections;

public class CorridorPuzzle : MonoBehaviour {
    private RoomScript room;
    private DialogSystem dialog;

    void CastSpell(GameState.SpellType spell) {
        
        if ((int)spell == (int)GameState.GhostBodyColor) {
            dialog.ShowText("The spell seems to be working!");
        } else {
            dialog.ShowText("The ghost is enraged, it seems to be moving faster!");
        }
    }

    // Use this for initialization
    void Start () {
        room = FindObjectOfType<RoomScript>();
        dialog = FindObjectOfType<DialogSystem>();
    }
	
	
}
