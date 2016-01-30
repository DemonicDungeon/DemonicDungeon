using UnityEngine;
using System.Collections;

struct MaterialPicker {
    public Material pink;
    public Material red;
    public Material green;
    public Material yellow;

    public MaterialPicker(Material p, Material r, Material g, Material y) {
        pink = p;
        red = r;
        green = g;
        yellow = y;
    }
}

public class Ghost : MonoBehaviour {

    public Material greenBody;
    public Material redBody;
    public Material pinkBody;
    public Material yellowBody;

    public Material greenEye;
    public Material redEye;
    public Material pinkEye;
    public Material yellowEye;

    public MeshRenderer bodyRenderer;
    public MeshRenderer leftEyeRenderer;
    public MeshRenderer rightEyeRenderer;

    public int GhostLives;

    private MaterialPicker bodyMaterial;
    private MaterialPicker eyeMaterial;

    public GameObject spells;

    private void SwitchMaterial(MeshRenderer theRenderer, GameState.GhostColor color, MaterialPicker material) {
        switch (color) {
            case GameState.GhostColor.Green:
                theRenderer.material = material.green;
                break;
            case GameState.GhostColor.Yellow:
                theRenderer.material = material.yellow;
                break;
            case GameState.GhostColor.Pink:
                theRenderer.material = material.pink;
                break;
            case GameState.GhostColor.Red:
                theRenderer.material = material.red;
                break;
            default:
                break;
        }
    }

    private void ChangeApperance() {

        GameState.GhostColor nextBody;
        GameState.GhostColor nextLeftEye;
        GameState.GhostColor nextRightEye;

        do {
            nextBody = (GameState.GhostColor)Random.Range(0, (int)GameState.GhostColor.NumColors);
        } while (nextBody == GameState.GhostBodyColor);

        do {
            nextLeftEye = (GameState.GhostColor)Random.Range(0, (int)GameState.GhostColor.NumColors);
        } while (nextLeftEye == GameState.GhostLeftEyeColor || nextLeftEye == nextBody);

        do {
            nextRightEye = (GameState.GhostColor)Random.Range(0, (int)GameState.GhostColor.NumColors);
        } while (nextRightEye == GameState.GhostRightEyeColor || nextRightEye == nextBody || nextRightEye == nextLeftEye);

        GameState.GhostBodyColor = nextBody;
        GameState.GhostLeftEyeColor = nextLeftEye;
        GameState.GhostRightEyeColor = nextRightEye;
        GameState.CorrectSpell = (GameState.SpellType)(6 - (int)nextBody - (int)nextLeftEye - (int)nextRightEye);

        SwitchMaterial(bodyRenderer, nextBody, bodyMaterial);
        SwitchMaterial(leftEyeRenderer, nextLeftEye, eyeMaterial);
        SwitchMaterial(rightEyeRenderer, nextRightEye, eyeMaterial);



        Invoke("ChangeApperance", GameState.GhostSpeed);
    }

    public void SpellHit() {
        GhostLives--;
        if (GhostLives == 0) {
            FindObjectOfType<CorridorPuzzle>().Success();
            gameObject.SetActive(false);
            spells.SetActive(false);
        } else {
            GameState.GhostSpeed *= 1.25f;
            CancelInvoke("ChangeApperance");
            ChangeApperance();
        }
    }

    public void SpellMiss() {
        GameState.GhostSpeed *= 0.8f;
        CancelInvoke("ChangeApperance");
        ChangeApperance();
    }


    // Use this for initialization
    void Start () {
        bodyMaterial = new MaterialPicker(redBody, pinkBody, greenBody, yellowBody);
        eyeMaterial = new MaterialPicker(redEye, pinkEye, greenEye, yellowEye);
        ChangeApperance();
    }
}
