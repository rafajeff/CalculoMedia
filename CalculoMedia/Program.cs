﻿using System;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal   n1, n2, media = 0;
            Console.WriteLine("Digite o primeiro valor");
            n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segunda valor");
            n2 = decimal.Parse(Console.ReadLine());
            media =( (n1 + n2) / 2);
            if (media >= 7)
            {
                Console.WriteLine( $"Parabens você fez 65. Sua média foi: {media}");

            }
            else
            {
                if (media > 5 && media < 7)
                {
                    Console.WriteLine($"Recuperation. Sua média: {media}");
                }
                else
                {
                    Console.WriteLine($"Se fodeu!!! Sua media foi: {media}");
                }
            }
        }
    }
}
