using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour {

    public BottlePuzzle puzzle;

    void Start() {
        puzzle = FindObjectOfType<BottlePuzzle>();
    }

    public void Interact() {
        Debug.Log("You pick up the bottle");
        gameObject.SetActive(false);
        puzzle.PickedUpBottle();
    }
}
