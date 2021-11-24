using System;
using System.Linq;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            char[] pismena1 = str1.ToCharArray();
            char[] pismena2 = str2.ToCharArray();
            string vysledok = string.Empty;

            for (int i = 0; i < pismena1.Length - 1; i++)
            {
                for (int j = 0; j < pismena2.Length - 1; j++)
                {
                    if (pismena1[i] == pismena2[j])
                    {
                        vysledok = vysledok + pismena1[i].ToString();
                    }
                }
            }
            return vysledok;
        }
    }
}
