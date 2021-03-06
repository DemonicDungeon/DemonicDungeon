﻿using UnityEngine;
using System.Collections;

public class Cauldron : MonoBehaviour {
	private DialogSystem dialog;
	private MeshRenderer renderer;
	private RoomScript room;

	private KitchenScript puzzle;

	public Material red_cauldron;
	public Material green_cauldron;
	public Material yellow_cauldron;
	public Material pink_cauldron;

	public void Interact() {
		if (puzzle.is_complete ()) {
			room.GoToNextLevel ();
		} else {
			dialog.ShowText ("I don't have all ingredients. It might kill me drinking this");
		}
	}

	private int get_fumes_count() {
		return System.Enum.GetNames (typeof(GameState.FumesColor)).Length;
	}

	// Use this for initialization
	void Start () {
		dialog = FindObjectOfType<DialogSystem> ();
		renderer = GetComponent<MeshRenderer> ();
		puzzle = FindObjectOfType<KitchenScript> ();
		room = FindObjectOfType<RoomScript> ();

		GameState.Fumes = (GameState.FumesColor) Random.Range (0, get_fumes_count());
		switch (GameState.Fumes)
		{
		case GameState.FumesColor.Red:
			dialog.ShowText ("Red fumes wildly dancing on top of the cauldron");
			renderer.material = red_cauldron;
			break;
		case GameState.FumesColor.Green:
			dialog.ShowText ("Cauldron spits some green stuff");
			renderer.material = green_cauldron;
			break;
		case GameState.FumesColor.Yellow:
			dialog.ShowText ("Cauldron spits some yellow stuff");
			renderer.material = yellow_cauldron;
			break;
		case GameState.FumesColor.Pink:
			dialog.ShowText ("Something pinky is cooking");
			renderer.material = pink_cauldron;
			break;
		default:
			dialog.ShowText ("You're  cannot understand the color of the fumes");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
