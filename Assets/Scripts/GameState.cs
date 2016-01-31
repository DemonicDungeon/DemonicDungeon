using UnityEngine;
using System.Collections;
using System.Linq;

public class GameState {

    public enum Drink {
        Beer,
        Wine,
        Vodka,
        Mead,
        NumDrinks
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
        Fire,
        NumSpells
    }
    public enum Ingridients { // NB must be same as object names in Kitchen scene
        Ananas,
        Bone,
        Pill,
        Plant,
        RedFlask
    }


    public static Candles CandleLit = Candles.NotLit;
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
    public static float GhostSpeed = 6;

    public static int[] symbolSolutionA = new int[] {
        0, 1, 2, 3, 4, 5, 6, 7, 8, 9
    };
    public static int[] symbolSolutionB = new int[] {
        9, 6, 3, 4, 2, 8, 1, 0, 7, 5
    };
    public static int[] symbolSolutionC = new int[] {
        2, 7, 0, 1, 6, 9, 4, 5, 3, 8
    };
    public static int[] symbolSolutionD = new int[] {
        6, 8, 4, 7, 5, 3, 0, 9, 2, 1
    };

    public static int[] ActiveSymbols = new int[] {9, 3, 2, 0, 5};
    public static int[] CorrectSymbols = new int[] {9, 3, 2, 0, 5 };

    public static void RandomizeGame() {
        GameState.HadDrink = (GameState.Drink)Random.Range(0, (int)GameState.Drink.NumDrinks);
        GameState.Time = (GameState.TimeOfDay)Random.Range(0, 2);
        GameState.CandleLit = (GameState.Candles)Random.Range(0, 2);

        CorrectSymbols[0] = Random.Range(0, 6);
        CorrectSymbols[1] = Random.Range(CorrectSymbols[0] + 1, 7);
        CorrectSymbols[2] = Random.Range(CorrectSymbols[1] + 1, 8);
        CorrectSymbols[3] = Random.Range(CorrectSymbols[2] + 1, 9);
        CorrectSymbols[4] = Random.Range(CorrectSymbols[3] + 1, 10);

        if (Random.value > 0.5) {
            CorrectSymbols[0] = 0;
            CorrectSymbols[1] = 1;
            CorrectSymbols[2] = Random.Range(2, 8);
            CorrectSymbols[3] = Random.Range(CorrectSymbols[2]+1, 9);
            CorrectSymbols[4] = Random.Range(CorrectSymbols[3]+1, 10);
        } else {
            CorrectSymbols[0] = symbolSolutionD[CorrectSymbols[0]];
            CorrectSymbols[1] = symbolSolutionD[CorrectSymbols[1]];
            CorrectSymbols[2] = symbolSolutionD[CorrectSymbols[2]];
            CorrectSymbols[3] = symbolSolutionD[CorrectSymbols[3]];
            CorrectSymbols[4] = symbolSolutionD[CorrectSymbols[4]];
        }

        ActiveSymbols = CorrectSymbols.OrderBy(x => Random.value).ToArray();
        if (GameState.CandleLit == GameState.Candles.Lit) {
            CorrectSymbols = CorrectSymbols.Reverse().ToArray();
        }
    }
}