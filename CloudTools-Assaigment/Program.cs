using System;
using System.Collections.Generic;
using static System.Console;

namespace CloudTools_Assaigment
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please write your numbers down as an intiger with comma separation.");
            var usersNumbers = ReadLine();
            var numbers = usersNumbers.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = new List<int>();

            foreach (var number in numbers)
            {
                int.TryParse(number, out int intNumber);
                if (intNumber != 0)
                {
                    intNumbers.Add(intNumber);
                }
            }
            
            var sum = intNumbers.Sum();
            WriteLine($"The SUM is:" + sum);
            WriteLine("Press a button to exit...");
            ReadKey();
        }
    }
}
