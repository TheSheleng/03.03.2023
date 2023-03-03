using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace _03._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            #region Task7
            //Console.Write("Write IPv4: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"IsIP: {IsIP(input)}");
            #endregion

            #region Task8
            //Console.Write("Write string: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"Number of vowels: {NumVowels(input)}");
            #endregion

            #region Task9
            //Console.Write("Write URL: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"IsIP: {IsURL(input)}");
            #endregion

            #region Task10
            //Console.Write("Write string: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"Is : {new Regex(@"\w*").Match(input).Success}");
            #endregion

            #region Task11
            //Console.Write("Write time: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"IsTime: {new Regex(@"^([01]\d|2[0-3]).([0-5]\d)$").Match(input).Success}");
            #endregion

            #region Task12
            //Console.Write("Write time: ");
            //input = Console.ReadLine();
            //Console.WriteLine($"IsTime: {new Regex(@"^\d{5}$").Match(input).Success}");
            #endregion

            Console.ReadKey();
        }
        static bool IsIP(string str)
        {
            return new Regex(@"^([01][0-9][0-9]|2[0-4][0-9]|25[0-5]).([01][0-9][0-9]|2[0-4][0-9]|25[0-5]).([01][0-9][0-9]|2[0-4][0-9]|25[0-5]).([01][0-9][0-9]|2[0-4][0-9]|25[0-5])$").Match(str).Success;
        }
        static int NumVowels(string str)
        {
            var match = Regex.Matches(str, @"[aeiouy]", RegexOptions.IgnoreCase);
            return match.Count;
        }
        static bool IsURL(string str)
        {
            return new Regex(@"^(https|https)://([a-z]\w*).(com|ru|ua)(/[a-z]\w*)*$").Match(str).Success;
        }
    }
}
