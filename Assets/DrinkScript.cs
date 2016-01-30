using UnityEngine;
using System.Collections;

public class DrinkScript : MonoBehaviour {

    public GameState.Drink KindOfDrink;

	// Use this for initialization
	void Start () {
        if (KindOfDrink != GameState.HadDrink)
            gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
