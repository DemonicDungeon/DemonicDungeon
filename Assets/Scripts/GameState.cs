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
        Green,
        Yellow,
        Pink
    }

    public enum GhostColor {
        Red,
        Pink,
        Green,
        Yellow,
        NumColors
    }
    public enum GhostParts {
        Body,
        RightEye,
        LeftEye
    }

    public enum SpellType {
        Earth,
        Air,
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

    public static int[] SpellTable = new int[] {
        1, 3, 0,
        0, 0, 3,
        2, 3, 2,
        1, 3, 2,

        2, 3, 1,
        1, 3, 2,
        0, 0, 2,
        3, 1, 1
    };
}