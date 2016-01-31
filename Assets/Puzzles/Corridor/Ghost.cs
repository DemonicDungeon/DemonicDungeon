using UnityEngine;
using System.Collections;

struct MaterialPicker {
    public Material red;
    public Material pink;
    public Material green;
    public Material yellow;

    public MaterialPicker(Material r, Material p, Material g, Material y) {
        red = r;
        pink = p;
        green = g;
        yellow = y;
    }
}

public class Ghost : MonoBehaviour {

    public ParticleSystem changeColor;
    public ParticleSystem spellHit;

    private MaterialPicker bodyMaterial;
    private MaterialPicker eyeMaterial;

    private GameState.GhostParts currentTarget;

    public float GhostSpeed;

    public GameObject spells;

    public Material redBody;
    public Material pinkBody;
    public Material greenBody;
    public Material yellowBody;

    public Material redEye;
    public Material pinkEye;
    public Material greenEye;
    public Material yellowEye;

    public MeshRenderer bodyRenderer;
    public MeshRenderer leftEyeRenderer;
    public MeshRenderer rightEyeRenderer;
    
    private void SwitchMaterial(MeshRenderer theRenderer, ref GameState.GhostColor color, MaterialPicker material) {
        color = (GameState.GhostColor)Random.Range(0, (int)GameState.GhostColor.NumColors);
        
        switch (color) {
            case GameState.GhostColor.Red:
                theRenderer.material = material.red;
                break;
            case GameState.GhostColor.Pink:
                theRenderer.material = material.pink;
                break;
            case GameState.GhostColor.Green:
                theRenderer.material = material.green;
                break;
            case GameState.GhostColor.Yellow:
                theRenderer.material = material.yellow;
                break;
            default:
                break;
        }
    }

    private void SetCorrectSpell() {
        int spellTableIdx = 12 * (int)GameState.Time;

        switch (currentTarget) {
            case GameState.GhostParts.Body:
                spellTableIdx += 3 * (int)GameState.GhostBodyColor;
                break;
            case GameState.GhostParts.RightEye:
                spellTableIdx += 3 * (int)GameState.GhostRightEyeColor + 1;
                break;
            case GameState.GhostParts.LeftEye:
                spellTableIdx += 3 * (int)GameState.GhostLeftEyeColor + 2;
                break;
            default:
                break;
        }
        GameState.CorrectSpell = (GameState.SpellType)GameState.SpellTable[spellTableIdx];
    }

    private void ChangeApperance() {

        changeColor.Emit(300);

        SwitchMaterial(bodyRenderer, ref GameState.GhostBodyColor, bodyMaterial);
        SwitchMaterial(leftEyeRenderer, ref GameState.GhostLeftEyeColor, eyeMaterial);
        SwitchMaterial(rightEyeRenderer, ref GameState.GhostRightEyeColor, eyeMaterial);

        SetCorrectSpell();

        //Invoke("ChangeApperance", GhostSpeed);
    }

    public void SpellHit() {


        spellHit.Emit(30) ;

        if (currentTarget == GameState.GhostParts.LeftEye) {
            FindObjectOfType<CorridorPuzzle>().Success();
            gameObject.SetActive(false);
            spells.SetActive(false);
        }

        currentTarget++;
        SetCorrectSpell();
    }

    public void SpellMiss() {
        currentTarget = GameState.GhostParts.Body;
        CancelInvoke("ChangeApperance");
        ChangeApperance();
    }
    
    // Use this for initialization
    void Start () {
        bodyMaterial = new MaterialPicker(redBody, pinkBody, greenBody, yellowBody);
        eyeMaterial = new MaterialPicker(redEye, pinkEye, greenEye, yellowEye);
        currentTarget = GameState.GhostParts.Body;
        ChangeApperance();
    }
}
