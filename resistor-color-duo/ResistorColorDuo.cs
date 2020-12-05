using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
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

        string resistor = "";
        foreach(string color in colors)
        {
            resistor += bandColors[color];
        }

        if(resistor.Length > 2)
        {
            resistor = resistor.Substring(0,2);
        }

        return int.Parse(resistor);

        throw new NotImplementedException("You need to implement this function.");
    }
}
