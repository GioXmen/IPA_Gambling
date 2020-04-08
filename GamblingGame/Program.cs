using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace GamblingGame
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            Console.WriteLine(new string('-', 474));
            Console.WriteLine("");
            Console.WriteLine(Art.horse(3));
            Console.WriteLine(Art.horse(7));
            Console.WriteLine(Art.horse(5));
            Console.WriteLine(Art.horse(9));
            Console.WriteLine("");
            Console.WriteLine(new string('-', 474));

            Console.WriteLine(Art.JoinLetters<Art.MyFont>(2, "dh"));


        }
    }
}
