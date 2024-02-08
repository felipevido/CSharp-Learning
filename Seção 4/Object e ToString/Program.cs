namespace Object_e_ToString;

class Program
{
    static void Main(string[] args)
    {

        Produtos inputProduct;
        inputProduct = new Produtos();
        int userAdd;
        int userRemove;

        System.Console.Write("Informe o nome do produto: ");
        inputProduct.Nome = Console.ReadLine();

        System.Console.Write("Informe o preço do produto: ");
        inputProduct.Preco = double.Parse(Console.ReadLine());

        System.Console.Write("Informe a quantidade do produto em estoque: ");
        inputProduct.Quantidade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dados do produto: " + inputProduct);

        System.Console.Write("Adicione mais produtos: ");
        userAdd = int.Parse(Console.ReadLine());
        inputProduct.AdicionarProdutos(userAdd);
        System.Console.WriteLine("Dados atualizados: " + inputProduct);

        System.Console.Write("Remova produtos do estoque: ");
        userRemove = int.Parse(Console.ReadLine());
        inputProduct.RemoverProdutos(userRemove);
        System.Console.WriteLine("Dados atualizados: " + inputProduct);
    }
}
