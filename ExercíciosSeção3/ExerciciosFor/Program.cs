// See https://aka.ms/new-console-template for more information

/*
System.Console.Write("Insira um número inteiro:");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i <= x; i++)
{
    if (i % 2 != 0)
    {
        System.Console.WriteLine($"O número {i} é ÍMPAR!");
    }
    else
    {
        System.Console.WriteLine($"O número {i} é PAR.");
    }
}
*/

System.Console.Write("Informe um valor inteiro: ");
int value = int.Parse(Console.ReadLine());

int inX = 0;
int outX = 0;

for (int count = 1; count <= value; count++)
{
    System.Console.Write("Informe um valor: ");
    double inputValue = double.Parse(Console.ReadLine()); 

    if (inputValue > 10 && inputValue < 20) {
        inX++;
    } else if (inputValue < 10 || inputValue > 20) { 
        outX++;
    }
}

System.Console.WriteLine($"{inX} in");
System.Console.WriteLine($"{outX} out");