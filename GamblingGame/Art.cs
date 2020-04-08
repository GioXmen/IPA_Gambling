using System;
using System.Collections.Generic;
using System.Linq;

namespace GamblingGame
{
    internal class Art
    {
        public interface IFont
        {
            Dictionary<char, Func<string[]>> Mapping { get; }
        }

        public class MyFont : IFont
        {
            public static string[] horse =
            {
                "        ,--,",
                "  _ ___/ / |",
                " ;( )__, )  ",
                "; //   '--; ",
                "  (     |   ",
                "   ^    ^   "
            };

        public static string[] dollar =
            {
                "        $        ",
                "     ,$$$$$,     ",
                "    ,$$$'$`$$$   ",
                "   $$$  $   `    ",
                "   '$$$,$        ",
                "     '$$$$,      ",
                "       '$$$$,    ",
                "        $ $$$,   ",
                "    ,   $  $$$   ",
                "    $$$,$.$$$'   ",
                "     '$$$$$'     ",
                "        $        "
            };
            public static string[] zero =
            {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$$_  $$",
                "| $$$$  $$",
                "| $$ $$ $$",
                "| $$  $$$$",
                "| $$   $$$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] one =
            {
                "        ",
                "        ",
                "   /$$  ",
                " /$$$$  ",
                "|_  $$  ",
                "  | $$  ",
                "  | $$  ",
                "  | $$  ",
                " /$$$$$$",
                "|______/",
                "        ",
                "        "
            };
            public static string[] two =
            {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$__  $$",
                "|__/  } $$",
                "  /$$$$$$/",
                " /$$____/ ",
                "| $$      ",
                "| $$$$$$$$",
                "|________/",
                "          ",
                "          "
            };
            public static string[] three =
            {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$__  $$",
                "|__/  } $$",
                "   /$$$$$/",
                "  |___  $$",
                " /$$  } $$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] four =
            {
                "          ",
                "          ",
                " /$$   /$$",
                "| $$  | $$",
                "| $$  | $$",
                "| $$$$$$$$",
                "|_____  $$",
                "      | $$",
                "      | $$",
                "      |__/",
                "          ",
                "          "
            };
            public static string[] five =
            {
                "          ",
                "          ",
                " /$$$$$$$ ",
                "| $$____/ ",
                "| $$      ",
                "| $$$$$$$ ",
                "|_____  $$",
                " /$$  } $$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] six =
            {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$__  $$",
                "| $$  |__/",
                "| $$$$$$$ ",
                "| $$__  $$",
                "| $$   |$$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] seven =
            {
                "          ",
                "          ",
                " /$$$$$$$$",
                "|_____ $$/",
                "     /$$/ ",
                "    /$$/  ",
                "   /$$/   ",
                "  /$$/    ",
                " /$$/     ",
                "|__/      ",
                "          ",
                "          "
            };
            public static string[] eight =
             {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$__  $$",
                "| $$  | $$",
                "|  $$$$$$/",
                " >$$__  $$",
                "| $$  | $$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] nine =
            {
                "          ",
                "          ",
                "  /$$$$$$ ",
                " /$$__  $$",
                "| $$  | $$",
                "|  $$$$$$$",
                "  ____  $$",
                " /$$  } $$",
                "|  $$$$$$/",
                "  ______/ ",
                "          ",
                "          "
            };
            public static string[] space =
{
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          ",
                "          "
            };
            public static string[] winner =
{
                "                                                             ",
                "                                                             ",
                " /$$      /$$ /$$                                         /$$",
                "| $$  /$ | $$|__/                                        | $$",
                "| $$ /$$$| $$ /$$ /$$$$$$$  /$$$$$$$   /$$$$$$   /$$$$$$ | $$",
                "| $$/$$ $$ $$| $$| $$__  $$| $$__  $$ /$$__  $$ /$$__  $$| $$",
                "| $$$$_  $$$$| $$| $$  } $$| $$  } $$| $$$$$$$$| $$   __/|__/",
                "| $$$/    $$$| $$| $$  | $$| $$  | $$| $$_____/| $$          ",
                "| $$/      $$| $$| $$  | $$| $$  | $$|  $$$$$$$| $$       /$$",
                "|__/      __/|__/|__/  |__/|__/  |__/  _______/|__/      |__/",
                "                                                             ",
                "                                                             ",
            };
            public static string[] looser =
{
                "                                                                ",
                "                                                                ",
                " /$$                                                         /$$",
                "| $$                                                        | $$",
                "| $$        /$$$$$$   /$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$ | $$",
                "| $$       /$$__  $$ /$$__  $$ /$$_____/ /$$__  $$ /$$__  $$| $$",
                "| $$      | $$  } $$| $$  } $$|  $$$$$$ | $$$$$$$$| $$   __/|__/",
                "| $$      | $$  | $$| $$  | $$  ____  $$| $$_____/| $$          ",
                "| $$$$$$$$|  $$$$$$/|  $$$$$$/ /$$$$$$$/|  $$$$$$$| $$       /$$",
                "|________/  ______/   ______/ |_______/   _______/|__/      |__/",
                "                                                                ",
                "                                                                "
            };

            public Dictionary<char, Func<string[]>> Mapping { get; }
                      = new Dictionary<char, Func<string[]>>{
                   { 'H', () => horse},
                   { 'D', () => dollar},
                   { '0', () => zero},
                   { '1', () => one},
                   { '2', () => two},
                   { '3', () => three},
                   { '4', () => four},
                   { '5', () => five},
                   { '6', () => six},
                   { '7', () => seven},
                   { '8', () => eight},
                   { '9', () => nine},
                   { 'S', () => space},
                   { 'W', () => winner},
                   { 'L', () => looser}};
        }

        public static string JoinLetters<T>(int space, string text)
        where T : class, IFont, new()
        {
            var font = new T();

            // get the letters
            var arrays = text.ToCharArray()
                             .Where(x => font.Mapping.ContainsKey(x))
                             .Select(x => font.Mapping[x].Invoke())
                             .ToList();

            // get the max height and width
            var h = arrays.Max(x => x.Length);
            var w = arrays.Max(x => x.Max(y => y.Length)) + space;

            var result = new string[h];

            // join each letter    
            // if the letter is too short, add default width
            foreach (var array in arrays) { 
                for (var j = 0; j < h; j++) { 
                    result[j] += (j >= array.Length ? " " : array[j]).PadRight(w);
                }
            }

            return string.Join(Environment.NewLine, result);
        }
    }
}