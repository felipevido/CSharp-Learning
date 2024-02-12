using System.Globalization;

namespace Fixação;

class Program
{
    static void Main(string[] args)
    {
        Retangulo dados;
        Funcionario info;
        info = new Funcionario();
        double porcentagem;

        
        dados = new Retangulo();

        Console.Write("Insira a largura do retangulo: ");
        dados.Largura = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

        System.Console.Write("Insira a altura do retangulo: ");
        dados.Altura = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

        System.Console.WriteLine(dados);

        System.Console.WriteLine("Informe o Nome, Salário Bruto e Imposto: ");
            string[] infoInput = Console.ReadLine().Split(' ');
                info.Nome = infoInput[0];
                info.SalarioBruto = double.Parse(infoInput[1]);
                info.Imposto = double.Parse(infoInput[2]);

        System.Console.WriteLine(info);
        
        System.Console.Write("Insira a porcentagem de aumento: ");
            porcentagem = double.Parse(Console.ReadLine());
                info.AumentarSalario(porcentagem);
        
        System.Console.WriteLine(info);
    }
}
