using System;
using System.Diagnostics;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "0") break;
                bool showNewLine;
                var inpInt32 = Convert.ToInt32(input);
                var data = CalculateFizzBuzz(inpInt32);
            }
        }

        public static string CalculateFizzBuzz(int inpInt32) => inpInt32 switch
        {
            _ when inpInt32 % 3 == 0 && inpInt32 % 5 == 0 => "FizzBuzz",
            _ when inpInt32 % 3 == 0 => "Fizz",
            _ when inpInt32 % 5 == 0 => "Buzz" 
        };
    }
}