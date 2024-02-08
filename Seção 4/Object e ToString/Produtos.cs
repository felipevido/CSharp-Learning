using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Object_e_ToString
{
    public class Produtos
    {
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int x){
            Quantidade += x;
        }

        public void RemoverProdutos(int y) {
            Quantidade -= y;
        }
        public override string ToString()
        {
            return Nome + ", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", Quantidade: " 
            + Quantidade + ", Total: "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}