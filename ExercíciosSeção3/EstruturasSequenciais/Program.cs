using System;
using System.Collections.Concurrent;
using System.Globalization;


System.Console.WriteLine("Informe dois valores inteiros separados por espaço:");

string[] number = Console.ReadLine().Split(' ');
int a = int.Parse(number[0]);
int b = int.Parse(number[1]);

double soma = a + b;
System.Console.WriteLine("A soma dos valores " + a + " + " + b + " são iguais a " + soma.ToString("F1", CultureInfo.InvariantCulture));



System.Console.WriteLine("Informa o valor do raio para que programa calcule a circunferência do círculo:");

double pi = 3.14159;
double raio = double.Parse(Console.ReadLine());

double calculoPi = pi * Math.Pow(raio, 2);
System.Console.WriteLine("A circunferência do raio " + raio + " é " + calculoPi.ToString("F4", CultureInfo.InvariantCulture));



System.Console.WriteLine("Digite 4 valores inteiros separados por espaço:");
string[] numbers = Console.ReadLine().Split(' ');

int w = int.Parse(numbers[0]);
int x = int.Parse(numbers[1]);
int y = int.Parse(numbers[2]);
int z = int.Parse(numbers[3]);

int difference = (w * x) - (y * z);
System.Console.WriteLine("A diferença dos valores inseridos foi: " + difference);



System.Console.WriteLine("Informe seu número de registro:");
int registerNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Informe a quantidade de horas trabalhadas esse mês:");
int hoursOfWork = int.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o valor de cada hora trabalhada:");
double valueHours = double.Parse(Console.ReadLine());

double salaryCalculation = hoursOfWork * valueHours;
System.Console.WriteLine("Funcionário de número: " + registerNumber);
System.Console.WriteLine("Seu salário é de R$" + salaryCalculation.ToString("F2", CultureInfo.InvariantCulture));


double valuePiece01 = 5.30;
double valuePiece02 = 5.10;

double userCart = 0;
char keepBuy;

do {

    System.Console.WriteLine("Código do produto:");
        int codProduct = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Quantidade comprada do produto Cod:" + codProduct);
        int qtdProduct = int.Parse(Console.ReadLine());
    
    if (codProduct == 1) {
        userCart += valuePiece01 * qtdProduct;
        }
        else if (codProduct == 2) {
            userCart += valuePiece02 * qtdProduct;
        } 
        else {
            System.Console.WriteLine("Ocorreu um erro. Tente novamente mais tarde!");
        }

    System.Console.WriteLine("Deseja continuar comprando? S ou N");
    keepBuy = char.Parse(Console.ReadLine());

    } while (keepBuy == 'S' || keepBuy == 's');

System.Console.WriteLine("O valor total de sua compra é de R$:" + userCart.ToString("F2"));


System.Console.WriteLine("Informe 3 valores separados por espaços:");
string[] valores = Console.ReadLine().Split(' ');

double aa = double.Parse(valores[0]);
double bb = double.Parse(valores[1]);
double cc = double.Parse(valores[2]);

double piValue = 3.14159;

double triangle = (aa * cc) / 2;
double circle = piValue * Math.Pow(cc, 2);
double trapezio = 1/2 * (aa + bb) * cc;
double quadrado = Math.Pow(bb, 2);
double rectangle = aa * bb;

System.Console.WriteLine("ÁREA DO TRIANGULO = " + triangle.ToString("F3"));
System.Console.WriteLine("ÁREA DO CÍRCULO = " + circle.ToString("F3"));
System.Console.WriteLine("ÁREA DO TRAPEZIO = " + trapezio.ToString("F3"));
System.Console.WriteLine("ÁREA DO QUADRADO = " + quadrado.ToString("F3"));
System.Console.WriteLine("ÁREA DO RETÂNGULO = " + rectangle.ToString("F3"));




