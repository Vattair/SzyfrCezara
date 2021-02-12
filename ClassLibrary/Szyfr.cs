using System;
using System.Linq;

namespace ClassLibrary
{
    public class Szyfr
    {

        public static string Szyfruj(string tekst, int p)
        {
            char[] alfabet = { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ż', 'Ź' };

            string Up = tekst.ToUpper();
            char[] data = Up.ToCharArray();
            char[] buffer = new char[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if(Array.IndexOf(alfabet, data[i]) == -1)
                {
                    //spacja
                    buffer[i] = data[i];
                }
                else
                {
                    int licznik = Array.IndexOf(alfabet, data[i]) + p;
                    if (licznik > 34) licznik -= 35;
                    buffer[i] = alfabet[licznik];
                }

            }
            return new string(buffer);
        }
        public static string Deszyfruj(string tekst, int p)
        {
            return Szyfruj(tekst, -p);
        }
    }
}
