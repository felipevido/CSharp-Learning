using System;
using System.Globalization;

/* EXERCÍCIO 1 
System.Console.WriteLine("Informe dois valores inteiros separados por espaço:");

string[] numbers = Console.ReadLine().Split(' ');
int x = int.Parse(numbers[0]);
int y = int.Parse(numbers[1]);

double soma = x + y;
System.Console.WriteLine("A soma dos valores " + x + " + " + y + " são iguais a " + soma.ToString("F1", CultureInfo.InvariantCulture));
*/

System.Console.WriteLine("Informa o valor do raio para que programa calcule a circunferência do círculo:");

double pi = 3.14159;
double raio = double.Parse(Console.ReadLine());

double calculoPi = pi * Math.Pow(raio, 2);
System.Console.WriteLine("A circunferência do raio " + raio + " é " + calculoPi.ToString("F4", CultureInfo.InvariantCulture));


