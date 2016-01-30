using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogSystem : MonoBehaviour {

    public Text dialog;

    public AudioSource sound;

    private string currentText;
    private string goalText;

    public float textFrequency;

    public void ShowText(string text) {
        dialog.text = "";
        currentText = "";
        goalText = text;

        Invoke("IterateText", textFrequency);
    }

    public void IterateText() {
        if (currentText == goalText)
            return;
        currentText += goalText[currentText.Length];
        dialog.text = currentText;
        sound.Play();
        Invoke("IterateText", textFrequency);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
