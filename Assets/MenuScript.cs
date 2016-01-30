using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public void StartGame() {
        FindObjectOfType<RoomScript>().GoToNextLevel();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
