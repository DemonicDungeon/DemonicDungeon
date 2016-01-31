using UnityEngine;
using System.Collections;

public class CorridorPuzzle : MonoBehaviour {
    private RoomScript room;
    private DialogSystem dialog;
    public bool LevelComplete;
    public int LevelTime;

    void TimesUp() {
        room.Death();
    }

    public void Success() {
        CancelInvoke("TimesUp");
        dialog.ShowText("Woohoo! The Ghost is gone!!");
        LevelComplete = true;
    }

    void CastSpell(GameState.SpellType spell) {
        
        if (spell == GameState.CorrectSpell) {
            dialog.ShowText("Yes! The Ghost is hurt!");
            FindObjectOfType<Ghost>().SpellHit();
        } else {
            dialog.ShowText("Oh no! The Ghost changed colors!");
            FindObjectOfType<Ghost>().SpellMiss();
        }
    }

    // Use this for initialization
    void Start () {
        LevelComplete = false;
        room = FindObjectOfType<RoomScript>();
        dialog = FindObjectOfType<DialogSystem>();

        Invoke("TimesUp", LevelTime);
    }
}
