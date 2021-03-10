using System;
using static System.Console;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            var aantalRijen = 3;
            var aantalKolommen = 3;

            var getallen = new int[aantalRijen, aantalKolommen];

            var getal = 1;

            for (var rij = 0; rij < aantalRijen; rij++)
            {
                for (var kolom = 0; kolom < aantalKolommen; kolom++)
                {
                    getallen[rij, kolom] = getal++;
                }
            }


            for (var rij = 0; rij < aantalRijen; rij++)
            {
                for (var kolom = 0; kolom < aantalKolommen; kolom++)
                {
                    Write($"{getallen[rij, kolom]} ");
                }
                WriteLine();
            }
        }
    }
}
