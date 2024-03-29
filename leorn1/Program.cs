﻿using System;

namespace leorn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "(()(()))";
            int switchValue = 0;
            int nesting = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    switchValue++;
                    nesting++;
                }
                else if (text[i] == ')' && switchValue > 0)
                {
                    switchValue--;
                }
                else
                {
                    switchValue--;
                    break;
                }
            }
            if (switchValue == 0)
            {
                Console.WriteLine(text);
                Console.WriteLine($"Cтрока корректная и максимум глубины равняется:{nesting - 1}");
            }
            else
            {
                Console.WriteLine("строка некорректная");
            }

            Console.ReadLine();
        }
    }
}
