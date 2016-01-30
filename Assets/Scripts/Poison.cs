using UnityEngine;
using System.Collections;

public class Poison : MonoBehaviour {

    public void Interact() {
        FindObjectOfType<RoomScript>().Death();
    }
}
