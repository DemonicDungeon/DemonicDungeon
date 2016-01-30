using UnityEngine;
using System.Collections;

public class WindowScript : MonoBehaviour {

    public Material day;
    public Material night;

    public GameObject light;

    // Use this for initialization
    void Start () {
        Renderer renderer = GetComponent<Renderer>();
	    if (GameState.Time == GameState.TimeOfDay.Day) {
            renderer.material = day;

        } else {
            renderer.material = night;
            light.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
