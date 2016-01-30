using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {
    public GameState.SpellType spellType;

	public void Interact() {
        FindObjectOfType<CorridorPuzzle>().SendMessage("CastSpell", spellType);
    }
}
