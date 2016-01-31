using UnityEngine;
using System.Collections;

public class KitchenScript : MonoBehaviour {

	private DialogSystem dialog;
	private RoomScript room;
	private bool LevelComplete;

	private int get_total_ingridients_count() {
		return System.Enum.GetNames(typeof(GameState.Ingridients)).Length;
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem> ();
		room = FindObjectOfType<RoomScript> ();
		Intro ();

		int ingridient1_hide = -1;
		int ingridient2_hide = -1;
		while (ingridient1_hide == ingridient2_hide) {
			ingridient1_hide = Random.Range (0, get_total_ingridients_count());
			ingridient2_hide = Random.Range (0, get_total_ingridients_count());
		}

		hide_ingridient (ingridient1_hide);
		hide_ingridient (ingridient2_hide);

		LevelComplete = false;
	}

	public bool is_complete() {
		return this.LevelComplete;
	}

	public void Intro() {
		dialog.ShowText ("Oh, looks like I tried to cook something. I wonder, if I used all the necessary ingredients.");
	}

	public void hide_ingridient(int ingridient_to_hide_idx) {
		GameState.Ingridients obj = (GameState.Ingridients)ingridient_to_hide_idx;
		GameObject.Find (obj.ToString()).SetActive (false);
	}

	public void fail_room() {
		Debug.Log ("Failed to met required conditions");
	}

	public void succed_room() {
		Debug.Log ("Correct ingredient was selected");
	}

	public bool ingridient_is_correct(GameState.Ingridients ingr, GameState.Drink drink, GameState.FumesColor fumes) {
		// Red Flask always work
		if (ingr == GameState.Ingridients.RedFlask) {
			return true;
		}

		if (fumes == GameState.FumesColor.Red) {
			switch (drink) {
			case GameState.Drink.Wine:
				if (ingr == GameState.Ingridients.Ananas)
					return true;
				break;
			case GameState.Drink.Beer:
				if (ingr == GameState.Ingridients.Bone)
					return true;
				break;
			case GameState.Drink.Vodka:
				if (ingr == GameState.Ingridients.Pill)
					return true;
				break;
			case GameState.Drink.Mead:
				if (ingr == GameState.Ingridients.Plant)
					return true;
				break;
			default:
				return false;
				break;
			}
		} else if (fumes == GameState.FumesColor.Yellow) {
			switch (drink) {
			case GameState.Drink.Wine:
				if (ingr == GameState.Ingridients.Plant)
					return true;
				break;
			case GameState.Drink.Beer:
				if (ingr == GameState.Ingridients.Bone)
					return true;
				break;
			case GameState.Drink.Vodka:
				if (ingr == GameState.Ingridients.Ananas)
					return true;
				break;
			case GameState.Drink.Mead:
				if (ingr == GameState.Ingridients.Pill)
					return true;
				break;
			default:
				return false;
				break;
			}
		} else if (fumes == GameState.FumesColor.Pink) {
			switch (drink) {
			case GameState.Drink.Wine:
				if (ingr == GameState.Ingridients.Plant)
					return true;
				break;
			case GameState.Drink.Beer:
				if (ingr == GameState.Ingridients.Pill)
					return true;
				break;
			case GameState.Drink.Vodka:
				if (ingr == GameState.Ingridients.Bone)
					return true;
				break;
			case GameState.Drink.Mead:
				if (ingr == GameState.Ingridients.Ananas)
					return true;
				break;
			default:
				return false;
				break;
			}
		} else if (fumes == GameState.FumesColor.Green) {
			switch (drink) {
			case GameState.Drink.Wine:
				if (ingr == GameState.Ingridients.Plant)
					return true;
				break;
			case GameState.Drink.Beer:
				if (ingr == GameState.Ingridients.Ananas)
					return true;
				break;
			case GameState.Drink.Vodka:
				if (ingr == GameState.Ingridients.Bone)
					return true;
				break;
			case GameState.Drink.Mead:
				if (ingr == GameState.Ingridients.Pill)
					return true;
				break;
			default:
				return false;
				break;
			}
		} else {
			Debug.Log ("Unknown fumes color. Assuming it's wrong");
			return false;
		}

		Debug.Log (string.Format("Ingr_id {0}, Drink: {1}, Fumes: {2}", ingr.ToString(), drink.ToString(), fumes.ToString()));

		return false;
	}

	public void IngridientSelected(CauldronIngredient obj) {
		GameState.Ingridients obj_ingr = (GameState.Ingridients) System.Enum.Parse (typeof(GameState.Ingridients), obj.name, true);
		if (ingridient_is_correct (obj_ingr, GameState.HadDrink, GameState.Fumes)) {
			dialog.ShowText ("Mmm! Let's drink this baby now!");
			LevelComplete = true;
		} else {
			dialog.ShowText ("Don't try this at home, kids!");
			room.Death ();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
