using System;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;

class Program
{

    static void Main()
    {
        string t = "ab ddfg";
        string tz = Szyfr.Szyfruj(t, 3);
        string po = Szyfr.Deszyfruj(tz, 3);
        Console.WriteLine("Do zaszyfrowania: "+t);
        Console.WriteLine("Po zaszyfrowaniu: " + tz);
        Console.WriteLine("Po odszyfrowaniu: " + po);
    }
}