using UnityEngine;
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
        Blue,
        Orange,
        Green
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

    public static Drink HadDrink = Drink.Wine;
    public static TimeOfDay Time = TimeOfDay.Night;
    public static FumesColor Fumes = FumesColor.Green;
    public static GhostColor GhostBodyColor = GhostColor.NumColors;
}