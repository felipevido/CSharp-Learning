namespace Seção_4;

class Program
{
    static void Main(string[] args)
    {
        Usuarios userA, userB; 

        userA = new Usuarios();
        userB = new Usuarios();

        System.Console.WriteLine("TESTE DE CLASSES");
        userA.Nome = Console.ReadLine();
        userA.Idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine(userA.Nome);
        System.Console.WriteLine(userA.Idade);

    }
}
