﻿namespace CodeWarsExercises.Codewars
{
    internal class EvenOrOddExercise : IExercise
    {
        public string Name => "Even or odd";

        public static bool IsEven(int n) => n % 2 == 0;

        public void Run()
        {
            // Note: 0 is even.
            Console.WriteLine(ConsoleUtils.ReadInt("Please, enter number: ") % 2 == 0 ? "Even" : "Odd");
        }
    }
}
