using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RoomScript : MonoBehaviour {

    public string NextRoom;
    
    public void Win() {
        SceneManager.LoadScene(NextRoom);
    }

    public void Death() {
        Application.Quit();
    }
    
    // Use this for initialization
    void Start () {
	
	}
}
