﻿namespace CodeWarsExercises.Codewars
{
    internal class CountTheMonkeysExercise : IExercise
    {
        private readonly bool _optimized;

        public CountTheMonkeysExercise(bool optimized)
        {
            _optimized = optimized;
        }

        public string Name => "Count the monkeys" + (_optimized ? " (optimized)" : string.Empty);

        public static int[] CountTheMonkeys(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n > 0");
            }

            int[] monkeys = new int[n];

            for (int x = 0; x < n; ++x)
            {
                monkeys[x] = x + 1;
            }

            return monkeys;
        }

        public void Run()
        {
            int n = ConsoleUtils.ReadInt("Enter the monkey count: ");

            if (_optimized)
            {
                ProduceOutputOptimized(n);
            }
            else
            {
                ProduceOutput(n);
            }
        }

        /// <summary>
        /// Produces monkey's output using CountTheMonkeys function under the hood.
        /// </summary>
        /// <param name="n">Count of monkeys.</param>
        private static void ProduceOutput(int n)
        {
            int[] monkey = CountTheMonkeys(n);

            Console.Write(monkey.Length);
            Console.Write(" --> [");

            for (int x = 0; x < monkey.Length; ++x)
            {
                Console.Write(monkey[x]);
                bool itemIsLast = x >= monkey.Length - 1;

                if (!itemIsLast)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }

        /// <summary>
        /// Produces monkey's output without any array allocation under the hood.
        /// </summary>
        /// <param name="n">Count of monkeys.</param>
        private static void ProduceOutputOptimized(int n)
        {
            Console.Write(n);
            Console.Write(" --> [");

            for (int x = 1; x <= n; ++x)
            {
                Console.Write(x);
                bool itemIsLast = x >= n;

                if (!itemIsLast)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}
