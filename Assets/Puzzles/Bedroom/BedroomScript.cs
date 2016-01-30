using UnityEngine;
using System.Collections;

public class BedroomScript : MonoBehaviour {

    private DialogSystem dialog;

    public float messageTime;

    private RoomScript room;
    void Start() {
        dialog = FindObjectOfType<DialogSystem>();
        Invoke("FuckMyHead", 2);
    }
    

    public void FuckMyHead() {
        dialog.ShowText("Oh f * **! My head! What did I do last night?");
        Invoke("OutdrinkGnome", messageTime);
    }

    public void OutdrinkGnome() {
        dialog.ShowText("That’d teach me to not try to outdrink a gnome.");
        Invoke("Hangover", messageTime);
    }

    public void Hangover() {
        dialog.ShowText(" But don’t be a pussy, it’s just a hangover.");
        Invoke("Demon", messageTime);
    }

    public void Demon() {
        dialog.ShowText("It’s not like I have summoned an evil demon from the 7th Hell, haha!");
        //Invoke("OutdrinkGnome", 3);
    }
}