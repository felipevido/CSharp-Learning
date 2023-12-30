using System;
using System.Collections.Concurrent;
using System.Globalization;
/*

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

*/


/*
System.Console.WriteLine("Informe um número inteiro:");
int number = int.Parse(Console.ReadLine());

int provaReal =  number % 2;

if (provaReal == 1) {
    System.Console.WriteLine("O número informado é ÍMPAR.");
} else {
    System.Console.WriteLine("O número informado é PAR.");
}
*/

/*
char userLoop;

do {
System.Console.WriteLine("Informe dois números:");

string[] valores = Console.ReadLine().Split(' ');
int a = int.Parse(valores[0]);
int b = int.Parse(valores[1]);


if (a % b == 0 || b % a == 0)
{
    System.Console.WriteLine("Os valores SÃO multiplos.");
}
else
{
    System.Console.WriteLine("Os valores NÃO são multiplos.");
}

System.Console.WriteLine("Tecle S para refazer e N para sair");
userLoop = char.Parse(Console.ReadLine());

} while (userLoop == 'S' || userLoop == 's');

*/

/*
char loop;

do {

System.Console.WriteLine("Que horas começou o jogo (somente números):");
int startHour = int.Parse(Console.ReadLine());
System.Console.WriteLine("Que horas terminou o jogo (somente números):");
int stopHour = int.Parse(Console.ReadLine());

int totalHours = startHour - stopHour;

if (totalHours < 0) {
    totalHours = Math.Abs(totalHours);
    System.Console.WriteLine($"o jogo durou {totalHours} horas.");
} else if (totalHours == 0){
    System.Console.WriteLine("O jogo durou 24 horas.");
} else {
    System.Console.WriteLine($"O jogo durou {totalHours} horas");
}

System.Console.WriteLine("Tecle S para refazer ou N para sair:");
loop = char.Parse(Console.ReadLine());

} while (loop == 'S' || loop == 's');

*/

double cachorroQuente = 4;
double xSalada = 4.50;
double xBacon = 5;
double torradaSimples = 2;
double refrigerante = 1.50;

char userLoop;
double comanda = 0;

System.Console.WriteLine("\n");
    System.Console.WriteLine("| Código | Nome do Produto | Valor do Produto |");
    System.Console.WriteLine("|--------|------------------|-------------------|");
    System.Console.WriteLine("    1      CACHORRO-QUENTE        R$4,00");
    System.Console.WriteLine("    2      X-SALADA               R$4,50");
    System.Console.WriteLine("    3      X-BACON                R$5,00");
    System.Console.WriteLine("    4      TORRADA SIMPLES        R$2,00");
    System.Console.WriteLine("    5      REFRIGERANTE           R$1,50");
    System.Console.WriteLine("\n");

do
{
    System.Console.WriteLine("Informe o código do produto e a quantidade:");
    string[] pedido = Console.ReadLine().Split(' ');
    int item = int.Parse(pedido[0]);
    int qtd = int.Parse(pedido[1]);

    if(item >= 1 && item <= 5) {

        switch(item) {
            case 1:
                comanda += qtd * cachorroQuente;
                break;
            case 2:
                comanda += qtd * xSalada;
                break;
            case 3:
                comanda += qtd * xBacon;
                break;
            case 4:
                comanda += qtd * torradaSimples;
                break;
            case 5:
                comanda += qtd * refrigerante;
                break;
        }
    } else {
        System.Console.WriteLine("Seu item não existe no cardápio. Tente novamente.");
    }

    System.Console.WriteLine("Adicionar Item: S - Finalizar Pedido: N");
    userLoop = char.Parse(Console.ReadLine());

} while (userLoop == 'S' || userLoop == 's');

System.Console.WriteLine("VALOR TOTAL: R$" + comanda.ToString("F2"));