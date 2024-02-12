using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Fixação
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double x){
           SalarioBruto = SalarioBruto + (SalarioBruto * x/100);
        }

        public override string ToString() {
            return "Funcionário: " + Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);  
        }
    }
}