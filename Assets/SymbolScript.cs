using UnityEngine;
using System.Collections;

public class SymbolScript : MonoBehaviour {
    public int Symbol;

    public void SetRune(int symbol, Material rune) {
        GetComponent<Renderer>().material = rune;
        this.Symbol = symbol;
    }
    
    public void Interact() {
        FindObjectOfType<SummoningPuzzle>().PressSymbol(Symbol);
    }
}
