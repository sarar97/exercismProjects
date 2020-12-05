using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        Dictionary<string, int> bandColors = new Dictionary<string, int>() {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9}
        };

        int resistance = (bandColors[colors[0]] * 10 + bandColors[colors[1]]) * (int)Math.Pow(10, bandColors[colors[2]]);
        if (resistance > 1000)
        {
            return (resistance / 1000).ToString() + " kiloohms";
        }
        else
        {
            return resistance.ToString() + " ohms";
        }
             

        throw new NotImplementedException("You need to implement this function.");
    }
}
