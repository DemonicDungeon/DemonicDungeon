using UnityEngine;
using System.Collections;

public class KitchenScript : MonoBehaviour {

	private DialogSystem dialog;

	private int get_total_ingridients_count() {
		return System.Enum.GetNames(typeof(GameState.Ingridients)).Length;
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem> ();
		Intro ();

		int ingridient1_hide = -1;
		int ingridient2_hide = -1;
		while (ingridient1_hide == ingridient2_hide) {
			ingridient1_hide = Random.Range (0, get_total_ingridients_count());
			ingridient2_hide = Random.Range (0, get_total_ingridients_count());
		}

		hide_ingridient (ingridient1_hide);
		hide_ingridient (ingridient2_hide);
	}

	public void Intro() {
		dialog.ShowText ("Oh, looks like I tried to cook something. I wonder, if I used all the necessary ingredients.");
	}

	public void hide_ingridient(int ingridient_to_hide_idx) {
		GameState.Ingridients obj = (GameState.Ingridients)ingridient_to_hide_idx;
		GameObject.Find (obj.ToString()).SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
