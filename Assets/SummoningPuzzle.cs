using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SummoningPuzzle : MonoBehaviour {

    public List<int> pressedSymbols = new List<int>();

    public void PressSymbol(int i) {

        Debug.Log("Click rune " + i);
        pressedSymbols.Add(i);
        if (!isCorrectList())
            room.Death();

        if (isFinishedList())
            Debug.Log("Win");
    }

    public bool isCorrectList() {
        if (pressedSymbols.Count > GameState.CorrectSymbols.Length)
            return false;

        for (int i = 0; i<pressedSymbols.Count; i++) {
            if (pressedSymbols[i] != GameState.CorrectSymbols[i])
                return false;
        }
        return true;
    }

    public bool isFinishedList() {
        return isCorrectList() && pressedSymbols.Count == GameState.CorrectSymbols.Length;
    }

    private DialogSystem dialog;

    private RoomScript room;
    
    // Use this for initialization
    void Start() {
        dialog = FindObjectOfType<DialogSystem>();
        room = FindObjectOfType<RoomScript>();
    }

}
