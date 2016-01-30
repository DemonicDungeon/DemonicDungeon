using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RoomScript : MonoBehaviour {

    public string NextRoom;

    private Animator animator;
    
    public void GoToNextLevel() {
        animator.SetTrigger("NextLevel");
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(NextRoom);
    }

    public void Death() {
        Application.Quit();
    }
    
    // Use this for initialization
    void Start () {
        animator = FindObjectOfType<Animator>();
	}
}
