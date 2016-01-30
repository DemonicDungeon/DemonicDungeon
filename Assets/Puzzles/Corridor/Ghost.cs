using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {

    public Material greenGhost;
    public Material redGhost;
    public Material pinkGhost;
    public Material yellowGhost;

    private MeshRenderer myRenderer;

    void ChangeApperance() {
        GameState.GhostColor next;

        do {
            next = (GameState.GhostColor)Random.Range(0, (int)GameState.GhostColor.NumColors);
        } while (next == GameState.GhostBodyColor);

        GameState.GhostBodyColor = next;

        switch (GameState.GhostBodyColor) {
            case GameState.GhostColor.Green:
                myRenderer.material = greenGhost;
                break;
            case GameState.GhostColor.Yellow:
                myRenderer.material = yellowGhost;
                break;
            case GameState.GhostColor.Pink:
                myRenderer.material = pinkGhost;
                break;
            case GameState.GhostColor.Red:
                myRenderer.material = redGhost;
                break;
            default:
                break;
        }

        Invoke("ChangeApperance", 2);
    }

    // Use this for initialization
    void Start () {
        myRenderer = GetComponent<MeshRenderer>();
        ChangeApperance();
    }
}
