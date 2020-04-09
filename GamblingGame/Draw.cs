using System;

namespace GamblingGame
{
    internal class Draw
    {
        //Klasė kuri pavaizduoja arkliuką, priima atstumo kintamjį, kuris stumia arkliuką
        public static string horse(int distance)
        {
            String space = String.Empty;
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
                space += "      ";
            }
            for (int i = 0; i < horse.Length; i++)
            {
                result += space + horse[i] + "\n";
            };
            return result;
        }

        //Sukuriam visu arkliuku ir lengtynių trasą, kuri bus naudojama piešimui. 
        public static string drawHorses(int horse1, int horse2, int horse3, int horse4)
        {

            return new string('-', 474) + "" + "" + Draw.horse(horse1) + Draw.horse(horse2) + Draw.horse(horse3) + Draw.horse(horse4) +
                "" + new string('-', 180) + "FINISH" + new string('-', 288) + "" + "" + new string('-', 237);
        }

        //Piešiam pinigų likutį
        public static string printMoney(int money)
        {
            return Art.JoinLetters<Art.HorceRaceFont>(0, "D" + money);
        }

        //Piešiam pinigų likutį su laimėjimo tekstu
        public static void printMoneyWin(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.HorceRaceFont>(-44, "D"+ money +"SSSW"));

        }

        //Piešiam pinigų likutį su pralaimėjimo tekstu
        public static void printMoneyLoose(int money)
        {
            Console.WriteLine(Art.JoinLetters<Art.HorceRaceFont>(-47, "D" + money + "SSSL"));

        }

        //Piešiam visu arkliuku ir lengtynių trasą, kuri buvo sukurta iš "drawHorses". 
        public static void drawRace(string result)
        {
            Console.Write(result);
        }
    }
}