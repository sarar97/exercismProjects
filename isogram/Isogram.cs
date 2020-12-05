using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (String.IsNullOrWhiteSpace(word))
        {
            return true;
        }
        else
        {
            word = word.ToLower();
            foreach(char letter in word) //getting each character in word 
            {
                if(letter >= 'a' && letter <= 'z') //checking only letters, ignoring other characters
                {   
                    int count = 0; //letter occurrence counter                 
                    for (int i = 0; i < word.Length; i++) //go through all the letters in the word
                    {                        
                        if (word[i] == letter) //if the letter matches the letter in the foreach loop increse counter
                        { 
                            count++;
                            if(count > 1) //each letter should appear only once, if it appears more than once it's not an isogram
                            {
                                return false;
                            }
                        }                        
                    }                    
                }
            }
            return true;
        }

        //It's messy but it works 


        throw new NotImplementedException("You need to implement this function.");
    }
}
