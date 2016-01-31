using UnityEngine;
using System.Collections;

public class SymbolGenerator : MonoBehaviour {

    public Material[] symbolMaterials;

    public SymbolScript[] symbols;

    public void GenerateSymbols() {
        for (int i = 0; i< GameState.ActiveSymbols.Length; i++) {
            int symbolType = GameState.ActiveSymbols[i];
            symbols[i].SetRune(symbolType, symbolMaterials[symbolType]);
        }
    }

	// Use this for initialization
	void Start () {
        //GameState.RandomizeGame();
        GenerateSymbols();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
