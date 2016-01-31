using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SummoningPuzzle : MonoBehaviour {

    bool Dead = false;

    public List<int> pressedSymbols = new List<int>();

    public ParticleSystem explodeSystem;

    public GameObject pentagram;

    public float PuzzleTime;

    public void PressSymbol(int i) {

        if (Dead)
            return;

        Debug.Log("Click rune " + i);
        pressedSymbols.Add(i);
        if (!isCorrectList()) {
            room.Death();
            explodeSystem.Emit(50);
        }

        if (isFinishedList()) {
            CancelInvoke();
            room.Win();
            pentagram.SetActive(false);
        }
    }

    public bool isCorrectList() {
        if (pressedSymbols.Count > GameState.CorrectSymbols.Length)
            return false;

        for (int i = 0; i<pressedSymbols.Count; i++) {
            if (pressedSymbols[i] != GameState.CorrectSymbols[i])
                return false;
        }
        return true;
    }

    public bool isFinishedList() {
        return isCorrectList() && pressedSymbols.Count == GameState.CorrectSymbols.Length;
    }

    private DialogSystem dialog;

    private RoomScript room;
    
    // Use this for initialization
    void Start() {
        dialog = FindObjectOfType<DialogSystem>();
        room = FindObjectOfType<RoomScript>();

        Invoke("Death", PuzzleTime);

        StartCoroutine(Story());
       
    }

    IEnumerator Story() {
        yield return new WaitForSeconds(1f);
        dialog.ShowText("Wow! So I really summoned a dark entity.");

        yield return new WaitForSeconds(6f);
        dialog.ShowText("So many years trying to spell the correct words with little success and I managed to do it when I was drunk.");

        yield return new WaitForSeconds(11f);
        dialog.ShowText("Now I don’t know how to banish it. No worries!");
        yield return new WaitForSeconds(6f);
        dialog.ShowText("It’s just a matter of time, it’s not like there will come any ghost to posses my soul, right?");
    }
    

    public void Death() {
        room.Death();
        Dead = true;
    }

}
