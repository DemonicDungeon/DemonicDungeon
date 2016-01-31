using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public void StartGame() {
        GameState.RandomizeGame();
        FindObjectOfType<RoomScript>().GoToNextLevel();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
