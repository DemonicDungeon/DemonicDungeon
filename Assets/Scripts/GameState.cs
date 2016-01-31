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
        Red,
        NumColors
    }

    public enum SpellType {
        Earth,
        Wind,
        Water,
        Fire
    }
    public enum Ingridients { // NB must be same as object names in Kitchen scene
        Ananas,
        Bone,
        Pill,
        Plant,
        RedFlask
    }


    public static Drink HadDrink = Drink.Wine;
    public static TimeOfDay Time = TimeOfDay.Night;
    public static FumesColor Fumes = FumesColor.Green;
    public static GhostColor GhostBodyColor = GhostColor.NumColors;
    public static GhostColor GhostLeftEyeColor = GhostColor.NumColors;
    public static GhostColor GhostRightEyeColor = GhostColor.NumColors;
    public static SpellType CorrectSpell = SpellType.Earth;

    public static float GhostSpeed = 6;

    public static int[] ActiveSymbols = new int[] { 2, 4, 5, 3, 1 };
    public static int[] CorrectSymbols = new int[] { 2, 4, 5 };

}