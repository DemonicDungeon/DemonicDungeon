using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour {
    public void Interact() {
        Debug.Log("You pick up the bottle");
        gameObject.SetActive(false);
    }
}
