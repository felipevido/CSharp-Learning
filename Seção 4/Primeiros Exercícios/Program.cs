namespace Primeiros_Exercícios;

class Program
{
    static void Main(string[] args)
    {
        Pessoas pessoa_1, pessoa_2;
        pessoa_1 = new Pessoas();
        pessoa_2 = new Pessoas();

        /* MODELO BÁSICO

        System.Console.Write("Informe o nome da primeira pessoa a seguir: ");
            pessoa_1.Nome = Console.ReadLine();
        System.Console.Write("Agora informe a idade dessa pessoa: ");
            pessoa_1.Idade = int.Parse(Console.ReadLine());

        System.Console.Write("Agora informe o nome da segunda pessoa: ");
            pessoa_2.Nome = Console.ReadLine();
        System.Console.Write("Informe a idade dessa pessoa: ");
            pessoa_2.Idade = int.Parse(Console.ReadLine());

        if (pessoa_1.Idade > pessoa_2.Idade) {
            System.Console.WriteLine($"{pessoa_1.Nome} é mais velha(o) que {pessoa_2.Nome}");
        } else if (pessoa_1.Idade == pessoa_2.Idade) {
            System.Console.WriteLine("Ambas as pessoas possuem a mesma idade.");
        } else {
            System.Console.WriteLine($"{pessoa_2.Nome} é mais velho que {pessoa_1.Nome}");
        }

        */

    char user_response;

    do {
    System.Console.Write("Informe dois nomes e duas idades intercaladamente: ");
    string[] userInput = Console.ReadLine().Split(' ');

        pessoa_1.Nome = userInput[0];
        pessoa_1.Idade = int.Parse(userInput[1]);
        pessoa_2.Nome = userInput[2];
        pessoa_2.Idade = int.Parse(userInput[3]);

            if (pessoa_1.Idade > pessoa_2.Idade) {
                System.Console.WriteLine($"A pessoa {pessoa_1.Nome} é mais velha que {pessoa_2.Nome}!");
            } else if (pessoa_1.Idade == pessoa_2.Idade) {
                System.Console.WriteLine($"A pessoa {pessoa_1.Nome} possui a mesma idade que a {pessoa_2.Nome}!");
            } else {
                System.Console.WriteLine($"A pessoa {pessoa_2.Nome} é mais velha que a pessoa {pessoa_1.Nome}");
            }


        System.Console.Write("S: REFAZER OPERAÇÃO - N: FINALIZAR PROGRAMA = ");
        user_response = char.Parse(Console.ReadLine());

    } while (user_response == 'S' || user_response == 's');

    }
}
