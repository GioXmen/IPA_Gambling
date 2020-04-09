using System;
using System.Linq;

namespace GamblingGame
{
    internal class Race
    {
        //Sukuriam atsitiktinius skaičius, priskiriam arkliukam, ir tas kuris turi didžiausią, gauną galimybę judėti
        public static void horseRace()
        {
            Random rnd = new Random();

            for (int i = 0; i < Program.horses.Count(); i++)
            {
                Program.horses[i].LuckScore = rnd.Next(1, 100);
            }

            string winner = Program.horses.Aggregate((i, j) => i.LuckScore > j.LuckScore ? i : j).id;
            Program.horses[Int32.Parse(winner) - 1].RealScore += 1;
        }
    }
}