﻿namespace P08_Most_Frequent_Number
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int longestStreak = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestStreak)
                {
                    longestStreak = counter;
                    mostFrequentNumber = numbers[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}