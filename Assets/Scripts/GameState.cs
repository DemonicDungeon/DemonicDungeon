﻿using UnityEngine;
using System.Collections;

public class GameState {

    public enum Drink {
        Beer,
        Wine,
        Vodka,
        Mead,
        BatBlood
    }

    public enum Candles {
        Lit,
        NotLit
    }

    public enum TimeOfDay {
        Day,
        Night
    }

    public enum FumesColor {
        Red,
        Green,
        Yellow,
        Pink
    }

    public enum GhostColor {
        Green,
        Yellow,
        Pink,
        Red
    }

    public enum Ingridients {
        Ananas,
        Bone,
        Pill,
        Plant,
        RedFlask
    }


    public static Drink HadDrink = Drink.Wine;
    public static TimeOfDay Time = TimeOfDay.Night;
    public static FumesColor Fumes = FumesColor.Pink;
    public static GhostColor GhostBodyColor = GhostColor.Pink;
}
