using System;
using System.Collections.Concurrent;
using System.Globalization;

int number = 0;
char loop;

do
{
    System.Console.WriteLine("Informe um número inteiro:");
    number = int.Parse(Console.ReadLine());
    
    if (number < 0)
    {
        System.Console.WriteLine("O número digitado é negativo.");
    }
    else
    {
        System.Console.WriteLine("O número digitado é positivo.");
    }
    System.Console.WriteLine("'S' para refazer e 'N' para finalizar:");
    loop = char.Parse(Console.ReadLine());
} while (loop == 'S' || loop == 's');