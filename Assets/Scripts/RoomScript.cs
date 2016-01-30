﻿using UnityEngine;
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
        animator.SetTrigger("Death");
    }

    public void LoadMainMenu() {
        SceneManager.LoadScene(0);
    }


    void Start () {
        animator = FindObjectOfType<Animator>();
	}
}
