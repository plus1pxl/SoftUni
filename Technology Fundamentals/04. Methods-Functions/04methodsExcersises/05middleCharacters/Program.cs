﻿using System;

namespace _06middleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[input.Length / 2 -1]}{input[input.Length / 2]}");
            }
            else if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}