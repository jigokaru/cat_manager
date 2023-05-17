using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.Helper
{
    enum InputType
    {
        Insert,
        Update,
        Delete
    }
    internal class InputHelper
    {
        public static int InputINT(string msg, string err)
        {
            bool check = true;
            int so;
            do
            {
                Console.WriteLine(msg);
                check = int.TryParse(Console.ReadLine(), out so);
                if (!check)
                {
                    Console.WriteLine(err);
                }
            } while (!check);
            return so;
        }
        public static string InputSTR(string msg, string err, int min = int.MinValue, int max = int.MaxValue)
        {
            bool check = true;
            string str = "";
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                check = str.Length >= min && str.Length <= max;
                if (!check)
                {
                    Console.WriteLine(err);
                }
            } while (!check);
            return str;
        }
        
    }
}
