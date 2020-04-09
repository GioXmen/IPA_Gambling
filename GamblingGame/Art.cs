using System;
using System.Collections.Generic;
using System.Linq;

namespace GamblingGame
{
    internal class Art
    {
        //Interfeisas musų sukurtai piešinių žodynui
        public interface IHorceFontInterface
        {
            Dictionary<char, Func<string[]>> Mapping { get; }
        }

        //Žodynas mūsų piešiniam, kuris integruojasi su interfeisu
        public class HorceRaceFont : IHorceFontInterface
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

            //Raides ir Simbolius sujungiam su žodyno piešiniais, kintamaisiais
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

        //Skaitom gaunama tekstą ir formatavimą, ir išverčiam kiekvieną simbolį į piešinį iš žodyno, bei sujungiam.
        public static string JoinLetters<T>(int space, string text)
                            where T : class, IHorceFontInterface, new()
        {
            var font = new T();

            // Nuskaityti ascii piešinį į masyvą
            var asciiArray = text.ToCharArray()
                             .Where(x => font.Mapping.ContainsKey(x))
                             .Select(x => font.Mapping[x].Invoke())
                             .ToList();

            // Gauti ilgiausią plotį ir aukštį
            var height = asciiArray.Max(x => x.Length);
            var width = asciiArray.Max(x => x.Max(y => y.Length)) + space;

            var result = new string[height];

            // Sujungiam kiekviena raidę    
            // Dinamiškai formatuojam tarpus pagal dydi/ilgį įvesties ASCII
            foreach (var asciiLine in asciiArray) { 
                for (var line = 0; line < height; line++) { 
                    result[line] += (line >= asciiLine.Length ? " " : asciiLine[line]).PadRight(width);
                }
            }

            return string.Join(Environment.NewLine, result);
        }
    }
}