using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GamblingGame
{
    class Program
    {
        //Nustatom globlų arklių sąrašą, bei konsolės dydžio parametrus
        public static List<Horse> horses = new List<Horse>();

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;
        static void Main(string[] args)
        {
            //Nustatom konsolės dydi
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            int Money = 500;
            int Bet = 0;
            Boolean exit = false;

            while (!exit) {
                //Duomenis žirgų pravalom ruošiantis naujoms lenktynėms
                Console.Clear();
                horses.Clear();

                //Žirgus sukuriam ir pridedam prie sarašo
                Horse horse1 = new Horse("1", 0);
                Horse horse2 = new Horse("2", 0);
                Horse horse3 = new Horse("3", 0);
                Horse horse4 = new Horse("4", 0);


                horses.Add(horse1);
                horses.Add(horse2);
                horses.Add(horse3);
                horses.Add(horse4);

                //Pavaizduojam pradinę žirgų poziciją ir pinigų likutį
                string result = string.Empty;
                Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore,
                                                horses[2].RealScore, horses[3].RealScore) + Draw.printMoney(Money) + "\n");

                //Pradedam duomenų įvestį iš vartotojo žaidimui
                Console.WriteLine("Kiek pinigu statysit? [Laimėjimas = 2 x Statymas / Pralaimėjimas = 3 x Statymas]");
                string tekstas = Console.ReadLine();
                Int32.TryParse(tekstas, out Bet);
                if (Bet > Money)
                {
                    Console.WriteLine("Neturite tiek pinigų!");
                    System.Threading.Thread.Sleep(500);
                    continue;
                }

                Console.WriteLine("Kuris žirgas [1, 2, 3, 4]?");
                string LuckyHorse = Console.ReadLine();
                if (!LuckyHorse.Equals("1") && !LuckyHorse.Equals("2") && !LuckyHorse.Equals("3") && !LuckyHorse.Equals("4") )
                {
                    Console.WriteLine("Netinkamai parinktas žirgas!");
                    System.Threading.Thread.Sleep(500);
                    continue;
                }

                //Pradedam lenktynes, kol žirgas neperžengė finisho zonos, tai tesiam lenktynes
                Console.Clear();
                while (horses.Aggregate((i, j) => i.LuckScore > j.LuckScore ? i : j).RealScore < 30)
                {
                    //Sukam "kauliuka", pagal kurį nusprendžiam kuris arkliukas gauna teisę judėti
                    Race.horseRace();
                    Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore,
                                                    horses[2].RealScore, horses[3].RealScore) + Draw.printMoney(Money));
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                }
                Console.Write(result);

                //Parodom galutinius rezultatus, ir naują pinigų likutį
                Draw.drawRace(Draw.drawHorses(horses[0].RealScore, horses[1].RealScore, horses[2].RealScore, horses[3].RealScore));
                if (horses.Aggregate((i, j) => i.LuckScore > j.LuckScore ? i : j).id == LuckyHorse)
                {
                    Money += Bet * 2;
                    Draw.printMoneyWin(Money);
                }
                else {
                    Money -= Bet * 3;
                    if (Money > 0) { 
                        Draw.printMoneyLoose(Money);
                    }
                    else Draw.printMoneyLoose(0);
                }

                //Jei pinigų likutis nesibaigė, tai duodam galimybę žaisti vėl
                if (Money <= 0)
                {
                    Console.WriteLine("Pralaimėjote visus turimus pinigus! Žaidimas baigtas!");
                    System.Threading.Thread.Sleep(500);
                    exit = true;
                }
                else { 
                Console.WriteLine("Zaisti toliau? [y/n]");
                string leave = Console.ReadLine();
                if (leave.Equals("n")) { exit = true; }
                }
            }
        }
    }
}
