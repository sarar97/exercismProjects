using System;

public static class ResistorColor
{

    public static int ColorCode(string color)
    {
        int colorVal = 0;
        string[] colorsArray = Colors();

        colorVal = Array.IndexOf(colorsArray, color);

        return colorVal;
    }

    public static string[] Colors() => new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
}