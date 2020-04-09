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
            string result = String.Empty;
            string[] horse =
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
                tab += "      ";
            }
            for (int i = 0; i < horse.Length; i++)
            {
                result += tab + horse[i] + "\n";
            };
            return result;
        }

        public static string drawHorses(int horse1, int horse2, int horse3, int horse4)
        {
            /*            Console.Write(new string('-', 474));
                        Console.Write("");
                        Console.Write(Draw.horse(horse1));
                        Console.Write(Draw.horse(horse2));
                        Console.Write(Draw.horse(horse3));
                        Console.Write(Draw.horse(horse4));
                        Console.Write("");
                        Console.Write(new string('-', 180) + "FINISH" + new string('-', 288));
                        Console.Write("");
                        Console.Write(new string('-', 237));*/

            return new string('-', 474) + "" + Draw.horse(horse1) + Draw.horse(horse2) + Draw.horse(horse3) + Draw.horse(horse4) +
                "" + new string('-', 180) + "FINISH" + new string('-', 288) + "" + new string('-', 237);
        }

        public static string printMoney(int money)
        {
            //Console.Write(Art.JoinLetters<Art.MyFont>(0, "D" + money));
            return Art.JoinLetters<Art.MyFont>(0, "D" + money);

        }

        public static void printMoneyWin(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.MyFont>(-44, "D"+ money +"SSSW"));

        }

        public static void printMoneyLoose(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.MyFont>(-47, "D" + money + "SSSL"));

        }

        public static void drawRace(string result)
        {
            Console.Write(result);

        }
    }
}