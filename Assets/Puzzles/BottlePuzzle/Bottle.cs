using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour {

    private BottlePuzzle puzzle;
    private DialogSystem dialog;

    void Start() {
        puzzle = FindObjectOfType<BottlePuzzle>();
        dialog = FindObjectOfType<DialogSystem>();
    }

    public void Interact() {
        dialog.ShowText("You pick up the bottle");
        gameObject.SetActive(false);
        puzzle.PickedUpBottle();
    }
}
