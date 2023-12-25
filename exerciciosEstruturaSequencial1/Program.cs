using System;
using System.Globalization;

System.Console.WriteLine("Informe dois valores inteiros separados por espaço:");

string[] numbers = Console.ReadLine().Split(' ');
int x = int.Parse(numbers[0]);
int y = int.Parse(numbers[1]);

double soma = x + y;
System.Console.WriteLine("A soma dos valores " + x + " + " + y + " são iguais a " + soma.ToString("F1", CultureInfo.InvariantCulture));