using UnityEngine;
using System.Collections;

public class CandleScript : MonoBehaviour {

    public GameState.Candles CandleState;

    // Use this for initialization
    void Start() {
        if (CandleState != GameState.CandleLit)
            gameObject.SetActive(false);
    }
}
