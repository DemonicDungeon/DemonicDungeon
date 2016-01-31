using UnityEngine;
using System.Collections;

public class SymbolScript : MonoBehaviour {
    public int Symbol;

    public ParticleSystem back;
    public ParticleSystem Explode;

    

    public void SetRune(int symbol, Material rune) {
        Debug.Log("Spawn rune " + symbol);
        GetComponent<Renderer>().material = rune;
        this.Symbol = symbol;
    }
    
    public void Interact() {
        FindObjectOfType<SummoningPuzzle>().PressSymbol(Symbol);

        Explode.Emit(30);
        back.gameObject.SetActive(false);
        GetComponent<Renderer>().enabled = false;
    }
}
