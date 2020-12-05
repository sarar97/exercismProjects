using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input == "") //checking if it's an empty string
        {
            return "";
        }
        else 
        {
            char[] charInput = input.ToCharArray(); //convert to a char array
            for (int i = 0, j = charInput.Length - 1; i < j; i++, j--)
            {
                char temp = charInput[i]; 
                charInput[i] = charInput[j]; 
                charInput[j] = temp; 
            }
            string revInput = string.Join("", charInput); //converting back to string

            return revInput;
        }

        throw new NotImplementedException("You need to implement this function.");
    }
}