using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200929
{
    class Tanulo
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
    }

    struct Bolygo
    {
        public string Nev { get; set; }
        public float EgyenlitoHossz { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //tömb == vektor == array

            //referencia-típusú adatszerkezet
            //több, azonos típusú elem tárolására 
            //alkalmas összetett adatszerkezet

            //ha a tömb nincs inicializálva, nem tudsz vele csinálni semmit!
            /*
                int[] t;
                Console.WriteLine(t.Length);  <-- syntax error
            */

            //jellemzően a deklarálás és az inicializálás egy sorban történik
            //init. része az elemszám megadása
            //lehet literál vagy változó is
            int[] t1 = new int[100];
            int n1 = 100;
            int[] t2 = new int[n1];

            //mivel a dec. és az init általában egy szekvencia, ezért több módis van:
            var t3 = new int[10];

            //tömböt literálokkal feltöltve is lehet inicializálni egy sorban:
            int[] t4 = { 1, 2, 3 };
            var t5 = new int[] { 1, 2, 3, };
            int[] t6 = new int[] { 1, 2, 3, };
            int[] t7 = new int[3] { 1, 2, 3, };

            //a fenti esetekben azért NEM kell feltétlenül megadni az elemszámot,
            //mert a felsorolásból "kiderül"
            //a lényeg, hogy a kód lefordításának 
            //pillanatában EGYÉRTELMŰ legyen az elemszám!

            //tehát nem kell hardcoding-ban rögzíteni feltétlenül:
            int n2 = int.Parse(Console.ReadLine());
            int[] t8 = new int[n2];

            //természetesen NEM csak egész számokat tartalmazó tömbök vannak -.-
            var t9 = new string[] { "macska", "ló", "pingvin" };
            var t10 = new Tanulo[10];
            Bolygo[] t11 = 
            {
                new Bolygo() { Nev = "Föld", EgyenlitoHossz = 40075.02F, },
                new Bolygo() { Nev = "Mars", EgyenlitoHossz = 21338.32F, },
            };




            Console.ReadKey();
        }
    }
}
