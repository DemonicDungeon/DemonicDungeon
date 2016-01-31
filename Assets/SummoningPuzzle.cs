using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SummoningPuzzle : MonoBehaviour {

    public List<int> pressedSymbols = new List<int>();

    public void PressSymbol(int i) {
        pressedSymbols.Add(i);
        if (!isCorrectList())
            room.Death();
    }

    public bool isCorrectList() {
        for (int i = 0; i<pressedSymbols.Count; i++) {
            if (pressedSymbols[i] != GameState.CorrectSymbols[i])
                return false;
        }
        return true;
    }

    private DialogSystem dialog;

    private RoomScript room;
    
    // Use this for initialization
    void Start() {
        dialog = FindObjectOfType<DialogSystem>();
        room = FindObjectOfType<RoomScript>();
    }

}
