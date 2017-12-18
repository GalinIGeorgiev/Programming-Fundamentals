﻿namespace P09_Refactor_Special_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;

                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                bool isNumberCorrect = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isNumberCorrect}");
            }
        }
    }
}