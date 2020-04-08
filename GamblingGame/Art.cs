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
            public static string[] one =
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
            public static string[] two =
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
            public static string[] three =
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
            public static string[] four =
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
            public static string[] five =
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
            public static string[] six =
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
            public static string[] seven =
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
            public static string[] eight =
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
            public static string[] nine =
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

            public Dictionary<char, Func<string[]>> Mapping { get; }
                      = new Dictionary<char, Func<string[]>>{
                   { 'h', () => horse},
                   { 'd', () => dollar}};
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
            foreach (var array in arrays)
                for (var j = 0; j < h; j++)
                    result[j] += (j >= array.Length ? " " : array[j]).PadRight(w);

            return string.Join(Environment.NewLine, result);
        }

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

        public static string money()
        {
            String tab = String.Empty;
            string astring = String.Empty;
            string[] aarray =
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

            for (int i = 0; i < aarray.Length; i++)
            {
                astring += aarray[i] + "\n";
            };
            return astring;
        }
    }
}