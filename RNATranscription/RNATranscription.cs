using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //char[] ntide = nucleotide.ToCharArray();
            string rna = "";
            foreach (char i in nucleotide)
            //for(int i = 0; i< ntide.Length; i++)
            {
                switch (i)
                {
                    case 'G':
                        { rna += "C".ToString();
                            break;
                        }
                    case 'A':
                        {
                            rna += "U".ToString();
                            break;
                        }
                    case 'C':
                        {
                            rna += "G".ToString();
                            break;
                        }
                    case 'T':
                        {
                            rna += "A".ToString();
                            break;
                        }
                }
            }

            return rna;
        }
    }
}
