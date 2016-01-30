using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {
    public GameState.SpellType spellType;

	public void Interact() {
        FindObjectOfType<DialogSystem>().ShowText("Casting Earth Spell!");
        FindObjectOfType<CorridorPuzzle>().SendMessage("CastSpell", spellType);
    }
}
