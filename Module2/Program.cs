using System;
using System.Linq;

namespace LinqCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Exercise 1
            // Func<int, int, int> multiply = (a, b) => a * b;
            // int result = multiply(5, 6);
            // Console.WriteLine("Multiply: " + result);
            //
            // Action<string> changeToUpperCase = message => Console.WriteLine(message.ToUpper());
            // changeToUpperCase("hello world");

            //Exercise 2
            // Func<string, bool> checkStringLength = str =>
            // {
            //     if (str.Length > 5) return true;
            //     return false;
            // };
            // Console.WriteLine(checkStringLength("Rudr"));

            //Exercise 3
            // Func<int, string> checkTemperature = temp =>
            // {
            //     if (temp < 0) return "Freezing";
            //     if (temp > 0 && temp < 20) return "Cold";
            //     if (temp > 21 && temp < 35) return "Warm";
            //     if (temp > 35) return "Hot";
            //     return null;
            // };
            // Console.WriteLine(checkTemperature(12));

            //Exercise 4
            List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // var result = numbers.Where(num => num > 5).ToList();
            // foreach (var num in result)
            // {
            //     Console.WriteLine(num);
            // }
            var result2 = numbers.Select(num => num).ToList();
            foreach(var num in result2)
            {
                if ((num * num) > 5)
                {
                    Console.WriteLine(num * num);
                }
            }
    }
    }
}