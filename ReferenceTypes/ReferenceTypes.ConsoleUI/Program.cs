using System;

namespace ReferenceTypes.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int number1 = 20;
            int number2 = 30;

            number1 = number2;
            number2 = 45;

            Console.WriteLine(number1);

            //reference types
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 4, 5, 6 };

            numbers1 = numbers2;
            numbers2[0] = 60;

            Console.WriteLine(numbers1[0]);
            Console.ReadLine();

        }
    }
}
