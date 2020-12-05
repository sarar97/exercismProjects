using System;

public static class Pangram
{
    public static bool IsPangram(string input) {

        input = input.ToLower(); //making sure the input is all lowercase
        

        if (String.IsNullOrWhiteSpace(input)) //checking if the input is an empty string, null or white space only
        {
            return false;
        }
        else 
        {
            for (char i = 'a'; i <= 'z'; i++) //goint from a to z
            {
                if (!input.Contains(i)) //if it doesn't contain one of the letters return false
                    return false;
            }
            return true;
        }
        

        throw new NotImplementedException();
    }
}
