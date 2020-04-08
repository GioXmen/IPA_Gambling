using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace GamblingGame
{
    class Program
    {
        public static List<Horse> horses = new List<Horse>();

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        private const int MAXIMIZE = 3;
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            int Money = 500;
            int Bet = 0;
            Boolean exit = false;

            while(!exit) {
                Console.Clear();
                horses.Clear();
                Horse horse1 = new Horse("1", 0);
                Horse horse2 = new Horse("2", 0);
                Horse horse3 = new Horse("3", 0);
                Horse horse4 = new Horse("4", 0);


                horses.Add(horse1);
                horses.Add(horse2);
                horses.Add(horse3);
                horses.Add(horse4);

                string result = string.Empty;
                Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore, horses[2].RealScore, horses[3].RealScore) + Draw.printMoney(Money) + "\n");

                Console.WriteLine("Kiek pinigu statysit?");
                string tekstas = Console.ReadLine();
                Int32.TryParse(tekstas, out Bet);

                Console.WriteLine("Kuris žirgas [1, 2, 3, 4]?");
                string LuckyHorse = Console.ReadLine();

                Console.Clear();
                while (horses.Aggregate((i, j) => i.LuckScore > j.LuckScore ? i : j).RealScore < 30)
                {
                    Race.horseRace();
                    Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore, horses[2].RealScore, horses[3].RealScore) + Draw.printMoney(Money));
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                }
                Console.Write(result);

                Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore, horses[2].RealScore, horses[3].RealScore));
                if (horses.Aggregate((i, j) => i.LuckScore > j.LuckScore ? i : j).id == LuckyHorse)
                {
                    Money += Bet * 2;
                    Draw.printMoneyWin(Money);
                }
                else {
                    Money -= Bet * 3;
                    Draw.printMoneyLoose(Money);
                }

                Console.WriteLine("Zaisti toliau? [y/n]");
                string leave = Console.ReadLine();

                if (leave.Equals("y")) { exit = true; }

            }
        }
    }
}
