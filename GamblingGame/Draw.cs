using System;
using System.Collections.Generic;
using System.Linq;

namespace GamblingGame
{
    internal class Draw
    {
        public static string horse(int distance)
        {
            String tab = String.Empty;
            string astring = String.Empty;
            string[] aarray =
            {
                "        ,--,",
                "  _ ___/ / |",
                " ;( )__, )  ",
                "; //   '--; ",
                "  (     |   ",
                "   ^    ^   "
            };
            for (int i = 0; i < distance; i++)
            {
                tab += "\t";
            }
            for (int i = 0; i < aarray.Length; i++)
            {
                astring += tab + aarray[i] + "\n";
            };
            return astring;
        }

        public static void drawHorses(int horse1, int horse2, int horse3, int horse4)
        {
            Console.WriteLine(new string('-', 474));
            Console.WriteLine("");
            Console.WriteLine(Draw.horse(horse1));
            Console.WriteLine(Draw.horse(horse2));
            Console.WriteLine(Draw.horse(horse3));
            Console.WriteLine(Draw.horse(horse4));
            Console.WriteLine("");
            Console.WriteLine(new string('-', 474));
            Console.WriteLine("");
        }

        public static void printMoney(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.MyFont>(0, "D" + money));

        }

        public static void printMoneyWin(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.MyFont>(-44, "D"+ money +"SSSW"));

        }

        public static void printMoneyLoose(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.MyFont>(-47, "D" + money + "SSSL"));

        }
    }
}