using UnityEngine;
using System.Collections;

public class DoNotUnload : MonoBehaviour {

    public static bool loaded;

	// Use this for initialization
	void Start () {
        if (!loaded)
            DontDestroyOnLoad(this);
        else
            Destroy(gameObject);
        loaded = true;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
