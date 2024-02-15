using System.Globalization;

namespace Conversor_De_Moeda;

class Program
{
    static void Main(string[] args)
    {
        
        double cotacaoDolar;
        double comprarDolar;
        Console.Write("Qual é a cotação do dólar? ");
        cotacaoDolar = double.Parse(Console.ReadLine());

        System.Console.Write("Quantos dólares você vai comprar? ");
        comprarDolar = double.Parse(Console.ReadLine());

        double total = ConversorDeMoeda.Conversor(cotacaoDolar, comprarDolar);
        System.Console.WriteLine("Valor a ser gasto em reais: " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}
