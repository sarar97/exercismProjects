using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if(String.IsNullOrWhiteSpace(nucleotide)){
            return "";
        }
        else {
            string rna = "";
            foreach(var x in nucleotide)
            {
                switch(x){
                    case 'A':
                        rna += 'U';
                        break;
                    case 'C':
                        rna += 'G';
                        break;
                    case 'G':
                        rna += 'C';
                        break;
                    case 'T':
                        rna += 'A';
                        break;
                 }
            }
            return rna;
        }

        throw new NotImplementedException("You need to implement this function.");
    }
}